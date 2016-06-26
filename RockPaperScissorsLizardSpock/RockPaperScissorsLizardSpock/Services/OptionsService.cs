using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock.Services
{
    public class OptionsService:IOptionsService
    {
        public List<string> GetOptionsName()
        {
            return new List<string>()
            {
                PlayType.ROCK,
                PlayType.PAPER,
                PlayType.SCISSORS,
                PlayType.LIZARD,
                PlayType.SPOCK
            };
        }

        public List<PlayBase> GetOptions()
        {
            return new List<PlayBase>
            {
                new Rock(),
                new Paper(),
                new Scissors(),
                new Lizard(),
                new Spock()
            };
        }
    }
}
