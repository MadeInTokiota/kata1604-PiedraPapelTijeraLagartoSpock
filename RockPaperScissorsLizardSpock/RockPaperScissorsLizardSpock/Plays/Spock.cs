using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public class Spock:PlayBase
    {
        public Spock()
        {
            this.Name = PlayType.SPOCK;
        }
        public override List<string> Wins()
        {
            return new List<string> { PlayType.SCISSORS, PlayType.ROCK };
        }
    }
}
