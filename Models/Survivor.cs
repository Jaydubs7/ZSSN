using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace SurvivorsTracking.Models
{
    public class Survivor
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Location LastLocation { get; set; }
        public List<Item> Inventory { get; set; }

        private string _name;
        private int _age;
        private Gender _gender;
        private Location _location;
        private List<Item> _inventory;
        private bool _infected;

        public Survivor(string name, int age, Gender gender, Location lastLocation, List<Item> inventory)
        {
            _name = name;
            _age = age;
            _gender = gender;
            LastLocation = lastLocation;
            _inventory = inventory;
            _name = name;
            _age = age;
            _gender = gender;
            _location = lastLocation;
            _inventory = inventory;
            _infected = false;
        }

        public List<Survivor> FetchSurvivors()
        {
            throw new NotImplementedException();
        }

        public Survivor UpdateSurvivorLocation(Location location)
        {
            throw new NotImplementedException();
        }

        public void FlagInfected()
        {
            _infected = true;
        }
    }


    public class Item
    {
        private string _name;
        private int _amount;
    }

    public class Location
    {
        private int _latitude;
        private int _longitude;
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
