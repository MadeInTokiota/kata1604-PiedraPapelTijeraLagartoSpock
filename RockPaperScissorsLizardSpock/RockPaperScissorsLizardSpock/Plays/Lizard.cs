using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public class Lizard : PlayBase
    {
        public Lizard()
        {
            this.Name = PlayType.LIZARD;
        }
        public override List<string> Wins()
        {
            return new List<string>() { PlayType.SPOCK, PlayType.PAPER };
        }
    }
}
