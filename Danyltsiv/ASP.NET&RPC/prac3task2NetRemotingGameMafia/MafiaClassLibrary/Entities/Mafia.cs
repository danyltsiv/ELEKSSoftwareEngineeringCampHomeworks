using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MafiaClassLibrary.Contracts;
using System.Timers;
using System.Collections;

namespace MafiaClassLibrary.Entities
{
    public class Mafia : MarshalByRefObject,IMafia
    {
        private static Object lockObj;
        private List<Player> players = new List<Player>();
        private string TIME = "DAY";
        private bool gameStatus = false;
        private string WINNER;

        public Mafia()
        {
            lockObj = new Object();
            gameStatus = true;
        }

        public string GetScreen(int id)
        {
            Player player = players.FirstOrDefault(g => g.id == id);

            string playersStatus = "";

            foreach (var pl in players) playersStatus += pl.ToString() + "\n";

            player.screen = "TIME: " + TIME + "\n" +
                "YOU: " + player.role + "\n" +
                "PLAYERS:\n" + playersStatus + 
                "MESSAGES:\n" + GetMessages(id) + "Type your command or help:\n";

            return player.screen;
        }
        
        public int RegisterPlayer(string playerNickname)
        {
            int playerId = 0;
            if (players.Count != 0)
                playerId = players.Select(g => g.id).Max() + 1;
            players.Add(new Player
            {
                id = playerId,
                nickname = playerNickname,
                status = "ALIVE",
                votes = 0,
                rightToVote = true                
            });
            return playerId;
        }

        public bool CheckGameStatus()
        {
            int CivilianAlive=0;
            int MafiaAlive=0;
            
            foreach(var pl in players)
            {
                if (pl.status == "ALIVE" && pl.role == "PEACEFUL") CivilianAlive++;
                if (pl.status == "ALIVE" && pl.role == "MAFIA") MafiaAlive++;
                if (pl.votes > players.Count / 2) pl.status = "LASTWORD";
            }
            if (MafiaAlive == 0)
            {
                gameStatus = false;
                WINNER = "PEACEFUL PEOPLE";
            }
            else if (MafiaAlive >= CivilianAlive)
            {
                gameStatus = false;
                WINNER = "MAFIA";
            }

            return gameStatus;
        }

        public void ExecuteCommand(int id, string message)
        {
            Player sender = players.FirstOrDefault(g => g.id == id);
            if (message == "help")
            {
                sender.messages.Add("\nAvailable commands:\nsay <MESSAGETEXT> (only when time = DAY)\n"+
                    "vote <NICKNAME> (only when time = DAY)\nkill <NICKNAME> (only if you are MAFIA and"+
                    "time = NIGHT)\nrestart (only if GAME OVER)\n\n");
            }
            else if (message == "restart" && !gameStatus)
            {
                this.NewRound();
            }
            else if (!gameStatus)
            {
                sender.messages.Add(String.Format("Game is over!WINNER IS {0}\nType restart to restart :)\n", WINNER));
            }
            else if (message.IndexOf("say ") == 0 && sender.status!="DEAD" && TIME=="DAY")
            {
                string cutedMsg = message.Remove(0, 4);
                if (sender.messages.Count > 20)
                    sender.messages.Remove(sender.messages[0]);
                
                messageToAll(sender.nickname + ":" + cutedMsg + "\n");

                if (sender.status=="LASTWORD") sender.status = "DEAD";
            }
            else if(message.IndexOf("kill ") == 0 && sender.role == "MAFIA" && sender.bullet 
                && TIME=="NIGHT" && players.Select(g=>g.nickname).Contains(message.Remove(0, 5)))
            {
                players.FirstOrDefault(g => g.nickname == message.Remove(0, 5)).status = "LASTWORD";
                sender.bullet = false;
                CheckGameStatus();
            }
            else if(message.IndexOf("vote ") == 0 && TIME=="DAY" && sender.rightToVote
                && players.Select(g => g.nickname).Contains(message.Remove(0, 5))
                && sender.status=="ALIVE")
            {
                players.FirstOrDefault(g => g.nickname == message.Remove(0, 5)).votes++;
                sender.rightToVote = false;
                CheckGameStatus();
            }
            else
            {
                sender.messages.Add("Wrong command or you are dead!\n");
            }
        }

        public void messageToAll(string message)
        {
            foreach (var pl in players)
                pl.messages.Add(message);
        }

        public string GetMessages(int id)
        {
            Player player = players.FirstOrDefault(g => g.id == id);
            return String.Join("", player.messages);
        }

        public void NewRound()
        {
            Random rnd = new Random();
            List<string> roles = new List<string>() {
                "MAFIA",
                "PEACEFUL",
                "PEACEFUL"
            };
         for (int i = 0; i < players.Count; i++)
            {
                int random = rnd.Next(roles.Count);
                players[i].role = roles[random];
                players[i].status = "ALIVE";
                players[i].votes = 0;
                players[i].rightToVote = true;
                players[i].messages.Clear();
                roles.Remove(roles[random]);
            }
            messageToAll("NEW GAME BEGINS!!!\n");
            gameStatus = true;
        }

        public int GetCountOfPlayers()
        {
            return players.Count;
        }

        public void ToggleTime()
        {
            if (TIME == "DAY") TIME = "NIGHT";
            else TIME = "DAY";

            for (int i = 0; i < players.Count; i++)
            {
                players[i].rightToVote = true;
                if (players[i].role == "MAFIA") players[i].bullet = true;
                if (players[i].status == "LASTWORD") players[i].status = "DEAD";
            }

            if (gameStatus && !CheckGameStatus())
            {
                string message = WINNER + " WON! WAIT FOR NEXT ROUND!\n";
                messageToAll(message);
            }
        }
    }
}
