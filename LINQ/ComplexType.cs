using System;
using System.Linq;
using system.collections.generic;
public class ComplexType
{
    public void LearnRestrections
    {
          var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country.Name;
            var euCountries = from country in countries 
                              where country.Continent == "Europe" && country.Population < 100000 
                              select country.Name;
            Console.WriteLine("European Countries");
            foreach (var country in euCountries)
            {
                Console.WriteLine(country);
            }

               //List of asian countries which are not ever invaded

           
            //var asCountries = countries.Where(country => country.Continent == "Asia" && country.IndependenceDay == default);
            Console.WriteLine("Asian Countries");
           // foreach(var country in asCountries){
              //  Console.WriteLine(country.Name);
            //}

           
            var asCountries2 = from country in countries
                               where country.Continent == "Asia" && country.IndependenceDay == default
                               select country;


            foreach(var country in asCountries2)
            {
                Console.WriteLine(country.Name);
            }
    }
}
      

