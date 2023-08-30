using MongoDB.Driver;
using SurvivorsTracking.Models;
using ZSSN_Octoco_technical_assessment.IRepository;
using ZSSN_Octoco_technical_assessment.Services;

namespace ZSSN_Octoco_technical_assessment.Repository
{
    public class SurvivorRepository: ISurvivorRepository
    {
        private readonly ISurvivorContext _survivorContext;

        public SurvivorRepository(ISurvivorContext survivorContext)
        {
            _survivorContext = survivorContext;
        }

        public async Task<List<Survivor>> GetAsync()
        {
            throw new NotImplementedException();
        }
        public async Task CreateAsync(Survivor survivor)
        {
            await _survivorContext.survivors.InsertOneAsync(survivor);
        }

        public async Task<List<Survivor>> GetAllAsync()
        {
            var filter = Builders<Survivor>.Filter.Empty;
            List<Survivor> survivors = await _survivorContext.survivors.FindAsync<Survivor>(filter).Result.ToListAsync();
            return survivors;
        }

        public Task UpdateOneAsync(string id, Survivor survivor)
        {
            throw new NotImplementedException();
        }
    }
}
