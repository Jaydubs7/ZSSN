using SurvivorsTracking.Models;

namespace ZSSN_Octoco_technical_assessment.IRepository
{
    public interface ISurvivorRepository
    {
        Task CreateAsync(Survivor survivor);
    }
}
