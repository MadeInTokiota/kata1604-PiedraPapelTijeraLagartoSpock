using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public class Paper :PlayBase
    {
        public Paper()
        {
            this.Name = PlayType.PAPER;
        }
        public override List<string> Wins()
        {
            return new List<string>() { PlayType.ROCK, PlayType.SPOCK };
        }

    }
}
