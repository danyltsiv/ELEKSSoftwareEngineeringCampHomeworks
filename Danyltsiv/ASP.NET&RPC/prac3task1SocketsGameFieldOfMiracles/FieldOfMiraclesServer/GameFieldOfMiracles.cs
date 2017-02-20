using System;
using System.Collections.Generic;
using System.Timers;
using System.Text.RegularExpressions;

namespace FieldOfMiraclesServer
{
    public class GameFieldOfMiracles
    {
        public Dictionary<string, int> statictic = new Dictionary<string, int>();
        private Dictionary<string, bool> statusOfPlayers = new Dictionary<string, bool>();
        private int indexOfRandomQA;
        private bool gameStatus = false;
        public string hidedWord = "";
        public List<string> Questions = new List<string>()
        {
            "Capital of Great Britain?\n",
            "Satellite of Earth?\n"
        };
        public List<string> Answers = new List<string>()
        {
            "London",
            "Moon"
        };

        public string Reset()
        {
            hidedWord = "";
            gameStatus = true;

            foreach (string key in new List<string>(statusOfPlayers.Keys))
                statusOfPlayers[key] = true;

            Random rnd = new Random();
            indexOfRandomQA = rnd.Next(0, Answers.Count);

            for (int i = 0; i < Answers[indexOfRandomQA].Length; i++) hidedWord += '*';

            return "\nNew Game begins!\n"+Questions[indexOfRandomQA]+hidedWord;
        }        

        public string GetQuestion()
        {
            return Questions[indexOfRandomQA];
        }
        
        public string GetHidedWord(string nick)
        {
            if (!hidedWord.Contains("*"))
            {
                if (gameStatus) statictic[nick]++;
                gameStatus = false;                
                return "Congrats " + nick + "!";
            }
            return hidedWord;
        } 

        public string ExecuteCommand(string cmd,string nick)
        {
            Regex letterReg = new Regex(".$");
            Regex wordReg = new Regex("\\w+$");
                 
            
            if (cmd.Contains("stat"))
            {
                return String.Format("Player {0} wins {1} times", nick, statictic[nick].ToString());
            }
            else if (cmd.Contains("exit"))
            {
                Environment.Exit(0);
                return "null";
            }

            if (!statusOfPlayers[nick] || !gameStatus) return "Wait for next game!";

            if (cmd.Contains("letter"))
            {
                char letter = char.Parse(letterReg.Match(cmd).ToString());

                for (int i = 0; i < hidedWord.Length; i++)
                {
                    if (Answers[indexOfRandomQA][i] == letter)
                        hidedWord = hidedWord.Remove(i, 1).Insert(i, letter.ToString());
                }

                return GetHidedWord(nick);
            }
            else if (cmd.Contains("word"))
            {
               string word = wordReg.Match(cmd).ToString();

                if (word == Answers[indexOfRandomQA])
                {
                    statictic[nick]++;
                    gameStatus = false;
                    return "Congrats " + nick + "!";
                } else
                {
                    statusOfPlayers[nick] = false;
                    return "You lost!";
                }
            }
            else return "Wrong command!";
        }

        public void SetNickName(string nick)
        { 
            statictic.Add(nick, 0);
            statusOfPlayers.Add(nick, false);
        }
    }
}
