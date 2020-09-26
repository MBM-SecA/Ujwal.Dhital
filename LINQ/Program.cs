using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program 
    {
        static void Main () 
        {
            // LINQ : Language Integrated Query
            // LINQ to objects

           // int[] = numbers { 23, 34, 56, 12, 23, 89, 67, 10, 110, 334, 1, 2, 3, 45, 73, 11, 20 };

            // Fetch numbers which are greater than 50

            // Using method syntax- lambda expression
           // var result1 = numbers.Where (x => x > 50 && x < 70);

            //Using sqi query syntax- Query expression
          //  var result2 = from x in numbers
          //  where x > 50
          //  select x;

           // string[] names = { "bishnu", "abc", "ram", "ramesh", "james", "ronald", "Raygon", "Ramsy" };

            // Names having length > 3 and starts with letter 'R'
           // var result3 = names.Where (y => y.Length > 3 && y.StartsWith ("r"));
            //var result4 = from y in names
            //where y.Length > 3 && y.ToUpper ().StartsWith ("R")
            //select y;
            //foreach (var name in result4)
           // {
              //  Console.WriteLine (name);
          //  }

            var countries = Country.GetCountries();

          //  var asianCountries = from country in countries
                               //  where country.Continent == "Asia"
                                // select country.Name;
            var euCountries = from country in countries where country.Continent == "Europe" && country.Population < 100000 select country.Name;
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


            foreach(var country in asCountries2){
                Console.WriteLine(country.Name);
            }
            //HW : List countries in Europe which has population less than 100k
            //HW : List Asian countries which are not invaded.

        }
    }
}



