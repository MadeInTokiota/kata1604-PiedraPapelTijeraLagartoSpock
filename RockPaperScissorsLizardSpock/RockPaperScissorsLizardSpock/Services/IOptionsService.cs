using System.Collections.Generic;

namespace RockPaperScissorsLizardSpock.Services
{
    public interface IOptionsService
    {
        List<string> GetOptionsName();
        List<PlayBase> GetOptions();
    }
}

