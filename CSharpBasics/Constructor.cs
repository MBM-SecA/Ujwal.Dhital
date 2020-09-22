using System;
namespace AllAboutClasses
{
    public class Country
    {
        
        public string Name{get;set;}
         public int Population { get; set; }
         public readonly double AREA=43443.45; 
         public static readonly bool IsOnEarth;

         // Instance Constructor
         // Default Constructor
         public Country()
        {
 
        }
        // Parameterized Constructor
        public Country(string name)
        {
            Name =name;
        }
 
        public Country(string name,int population, double area)
        {
            Name =name;
            Population = population;
            AREA = area;
        }

        // Static Constructor   
        static Country()
        {
           IsOnEarth = true;
        }
         // Finalizer
        ~Country()
        {
            Console.WriteLine("I am dying..");
        }
 
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country coountry2 = new Country("Nepal");
 
        }
    }
}