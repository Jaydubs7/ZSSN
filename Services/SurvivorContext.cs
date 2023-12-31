﻿using ZSSN_Octoco_technical_assessment.Handles;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using SurvivorsTracking.Models;
using ZstdSharp;

namespace ZSSN_Octoco_technical_assessment.Services
{
    public class SurvivorContext: ISurvivorContext
    {
        private readonly IMongoDatabase _db;

        public SurvivorContext(IOptions<MongoDbSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            _db = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        }

        public IMongoCollection<Survivor> survivors => _db.GetCollection<Survivor>("survivor");

    }
}
