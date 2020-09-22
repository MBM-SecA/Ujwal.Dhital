using System;
using System.IO;
using System.Linq;
public class Program
{
    static void Main()
    {
 
      string countriesText = File.ReadAllText("Countries.txt");
      string[] countries = countriesText.Split("\r\n");

      var countriesWithNInitial = countries.Where(x => x.StartsWith("N")).Select(x => x);

      foreach (var country in countriesWithNInitial)
      {
          Console.WriteLine(country);
      }
 
    }
}

