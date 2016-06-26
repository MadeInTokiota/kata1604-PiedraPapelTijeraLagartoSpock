using RockPaperScissorsLizardSpock.Constants;
using RockPaperScissorsLizardSpock.Services;
using System;
using System.Linq;

namespace RockPaperScissorsLizardSpock
{
    public class Program
    {
        private static IOptionsService options;
        private static IPlayCheckService playCheck;
        
        static void Main(string[] args)
        {
            options = new OptionsService();
            playCheck = new PlayCheckService();

            foreach(var name in options.GetOptionsName())
            {
                Console.WriteLine(name);
            }

            var playerOneMove = askForOption(Messages.PLAYER_ONE);
            var playerTwoMove = askForOption(Messages.PLAYER_TWO);

            var winner = playCheck.GetWinner(playerOneMove, playerTwoMove);

            Console.WriteLine();
            Console.WriteLine(Messages.WINNER);
            Console.WriteLine(string.Format("¡{0}!", winner));
            Console.ReadLine();
        }

        private static string askForOption(string player)
        {
            var move = string.Empty;
            var isValid = false;

            while (isValid != true)
            {
                Console.WriteLine();
                Console.WriteLine(string.Format("{0}: {1}", player, Messages.CHOOSE_OPTION));
                move = Console.ReadLine();
                isValid = options.GetOptions().Where(o => o.Name.ToLowerInvariant().Equals(move.ToLowerInvariant())).Any();
            }

            return move;
        }
    }
}
