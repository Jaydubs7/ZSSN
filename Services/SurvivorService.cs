using SurvivorsTracking.Models;
using ZSSN_Octoco_technical_assessment.IRepository;
using ZSSN_Octoco_technical_assessment.Repository;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace ZSSN_Octoco_technical_assessment.Services
{
    public class SurvivorService
    {
        private readonly ISurvivorRepository _survivorRepository;

        public SurvivorService(ISurvivorRepository survivorRepository)
        {
            _survivorRepository = survivorRepository;
        }

        public async Task AddSurvivor(Survivor survivor)
        {
            await _survivorRepository.CreateAsync(survivor);
        }
        //Returns all survivors in alphabetical order
        public async Task<List<Survivor>> GetAllSurvivors() 
        {
            List<Survivor> orderedSurvivors = _survivorRepository.GetAllAsync().Result.OrderBy(s => s.Name).ToList();
            return orderedSurvivors;
        }

        public async Task UpdateLocation(string id, Location location)
        {
            await _survivorRepository.UpdateOneLocationAsync(id, location);
            return;
        }

        public async Task FlagInfectedSurvivor(string id)
        {
            await _survivorRepository.SetInfected(id);
            return;
        }
    }
}
