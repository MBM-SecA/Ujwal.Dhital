using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte> {2,3};
            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(255);
            
            List<Country> countries = new List<Country>();

            Country country1 = new Country();

            countries.Add(country1);
        }

        void LearnDisctionary()
        {
            var countryCapitals = new Dictionary<string, string>()
            {
                ["Nepal"] = "Kathmandu",
                ["India"] = "Delhi",
                ["Russia"] = "Moscco"
            };
            
            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital City: {country.}")
            }
            
        }
    }
    public class Country
    {
        public string Name {get; set;}
    }
}