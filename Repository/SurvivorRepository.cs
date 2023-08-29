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
            Console.Write("At Repo create....");
            await _survivorContext.survivors.InsertOneAsync(survivor);
        }
    }
}
