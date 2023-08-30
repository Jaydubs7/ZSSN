using SurvivorsTracking.Models;

namespace ZSSN_Octoco_technical_assessment.IRepository
{
    public interface ISurvivorRepository
    {
        Task CreateAsync(Survivor survivor);
        Task<List<Survivor>> GetAllAsync();
        Task UpdateOneAsync(string id, Survivor survivor);
    }
}
