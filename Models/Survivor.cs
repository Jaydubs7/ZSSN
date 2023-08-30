﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace SurvivorsTracking.Models
{
    public class Survivor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Location LastLocation { get; set; }
        public List<Item> Inventory { get; set; }

        public bool Infected { get; set; } = false;
        
        public Survivor()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }
    }

    public class Item
    {
        public string Name { get; set; }   
        public int Amount { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
