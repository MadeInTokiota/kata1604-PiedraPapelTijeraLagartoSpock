
using RockPaperScissorsLizardSpock.Constants;
using System.Linq;

namespace RockPaperScissorsLizardSpock.Services
{
    public class PlayCheckService : IPlayCheckService
    {
        private IOptionsService options;

        public PlayCheckService()
        {
            this.options = new OptionsService();
        }
        public string GetWinner(string playerOneMove, string playerTwoMove)
        {
            var winner = string.Empty;

            if (playerOneMove.Equals(playerTwoMove))
            {
                winner = Messages.EVEN;
            }
            else
            {
                var wins = options.GetOptions().Where(o => o.Name.Equals(playerOneMove.ToUpperInvariant())).FirstOrDefault().Wins();
                winner = wins.Contains(playerTwoMove.ToUpperInvariant()) ? Messages.PLAYER_ONE : Messages.PLAYER_TWO;
            }

            return winner;
        }
    }
}
