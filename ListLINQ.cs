using System;
using System.Collections.Generic;

namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");

            //teeme "andmebaasi"
            //ja selleks on vaja luua class nimega Person
            //mis on muutuja all nimega person
            IList<Person> person = new List<Person>()
            {
               new Person() {Id = 1, Name = "Mees", Age = 20 },
               new Person() {Id = 2, Name = "Naine", Age = 30 },
               new Person() {Id = 3, Name = "kkkk", Age = 65 },
               new Person() {Id = 4, Name = "Hmmm", Age = 90 },

            };
            //n[[d kasutame person muutujat uue muutja all
            //mille nimeks on persons
            var persons = from p in person
                         select new
                         {
                             Id = p.Id,
                             Name = p.Name,
                             Age = p.Age
                         };
            //kasutame muutuja persons, et näidata konsoolus tulemust
            foreach (var item in persons) 
            {
                Console.WriteLine(" Id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("Kasutame LINQ Selecti ehk teine variant");
            var result = person
                .OrderBy(p => p.Name)
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age
                });
            //kasutame result muutujat ja teeme ta lahti rea kaupu
            //läbi muutuja item
            foreach (var item in result)
            {
                Console.WriteLine(" Id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Gruppide kaupa sorteerimine");

            var groupBy = person
                .GroupBy(p => p.Age);

            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        
        }       
    }
}
