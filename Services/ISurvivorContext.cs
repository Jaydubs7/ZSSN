using MongoDB.Driver;
using SurvivorsTracking.Models;

namespace ZSSN_Octoco_technical_assessment.Services
{
    public interface ISurvivorContext
    {
        IMongoCollection<Survivor> survivors { get; }
    }
}
