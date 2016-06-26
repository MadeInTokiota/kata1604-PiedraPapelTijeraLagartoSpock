using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock
{
    public abstract class PlayBase
    {
        public string Name;
        public abstract List<string> Wins();
    }
}
