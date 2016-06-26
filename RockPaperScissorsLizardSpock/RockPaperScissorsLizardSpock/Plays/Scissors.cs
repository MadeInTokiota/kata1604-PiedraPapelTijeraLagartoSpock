using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public class Scissors : PlayBase
    {
        public Scissors()
        {
            this.Name = PlayType.SCISSORS;
        }
        public override List<string> Wins()
        {
            return new List<string>() { PlayType.PAPER, PlayType.LIZARD };
        }
    }
}
