namespace RockPaperScissorsLizardSpock.Services
{
    public interface IPlayCheckService
    {
        string GetWinner(string playerOneMove, string playerTwoMove);
    }
}
