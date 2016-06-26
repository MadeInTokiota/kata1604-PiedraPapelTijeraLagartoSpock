using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public class Rock : PlayBase
    {
        public Rock() 
        {
            this.Name = PlayType.ROCK;
        }
        public override List<string> Wins()
        {
            return new List<string>() { PlayType.SCISSORS, PlayType.LIZARD };
        }
    }
}
