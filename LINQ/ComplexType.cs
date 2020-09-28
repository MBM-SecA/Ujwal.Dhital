using System;
using System.Collections.Generic;
using System.Linq;

public class ComplexType
{
    public void LearnRestrections()
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
            // foreach(var country in asCountries2)
            //{
              //  Console.WriteLine(country.Name);
            //}

            
            //HW - Is there any african country in your country collection
            var anyAfricanCountry = countries.Any(x => x.Continent == "Africa");
            if (anyAfricanCountry){
                Console.WriteLine("Yes, there is an African Country in my country collection.");
            } else {
                Console.WriteLine("No, there is no any African countries in country collection");
            }

            //HW - print first 2 largest asian country names.
            var largestasCountry = countries.Where(x => x.Continent == "Asia").OrderBy(x => -x.Population).Take(2).Select(x => x.Name);
            Console.WriteLine("Two largest Asian Countries based on area are :");
            foreach(var country in largestasCountry){
                Console.WriteLine(country);
            }
    }

}
      

