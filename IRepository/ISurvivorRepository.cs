using SurvivorsTracking.Models;

namespace ZSSN_Octoco_technical_assessment.IRepository
{
    public interface ISurvivorRepository
    {
        Task CreateAsync(Survivor survivor);
        Task<List<Survivor>> GetAllAsync();

        Task<Survivor> GetByIdAsnyc(string id);
        Task UpdateOneLocationAsync(string id, Location location);
    }
}
