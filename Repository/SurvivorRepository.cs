using Microsoft.AspNetCore.Mvc;
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

        public async Task CreateAsync(Survivor survivor)
        {
            await _survivorContext.survivors.InsertOneAsync(survivor);
        }

        public async Task<List<Survivor>> GetAllAsync()
        {
            List<Survivor> survivors = await _survivorContext.survivors.FindAsync<Survivor>(_ => true).Result.ToListAsync();
            return survivors;
        }

        public async Task UpdateOneLocationAsync(string id, Location location)
        {
            var filter = Builders<Survivor>.Filter.Eq(s => s.Id, id);
            var update = Builders<Survivor>.Update.Set(s => s.LastLocation, location);
            await _survivorContext.survivors.UpdateOneAsync(filter, update);
            return;
        }

        public async Task<Survivor> GetByIdAsnyc(string id)
        {
            Survivor survivor = await _survivorContext.survivors.Find(s => s.Id == id).FirstOrDefaultAsync();
            return survivor;
        }

        public async Task SetInfected(string id) 
        {
            var filter = Builders<Survivor>.Filter.Eq(s => s.Id, id);
            var update = Builders<Survivor>.Update.Set(s => s.Infected, true);
            await _survivorContext.survivors.UpdateOneAsync(filter, update);
        }
    }
}
