using MafiaClassLibrary.Entities;

namespace MafiaClassLibrary.Contracts
{
    public interface IMafia
    {
        int RegisterPlayer(string playerNickname);
        void ExecuteCommand(int id, string message);
        string GetScreen(int id);
        int GetCountOfPlayers();
        void NewRound();
        void ToggleTime();
        bool CheckGameStatus();
    }
}
