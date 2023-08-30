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
            return await _survivorRepository.GetAllAsync();
        }

        public async Task UpdateLocation(string id, Location location)
        {
            throw new NotImplementedException();
        }

        public async Task FlagInfectedSurvivor(string id)
        {
            throw new NotImplementedException();
        }
    }
}
