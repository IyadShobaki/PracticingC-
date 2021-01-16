using System;
using System.Collections.Generic;
using System.Linq;

namespace ForEachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = GetPeople();
            //foreach (var p in people)
            //{
            //    Console.WriteLine($"Hello, {p}");
            //}
            people.ForEach(p => Console.WriteLine($"Hello, {p}"));

            //var sortedPeople = people.Where(p => p == "Adam").ToList();
            //Console.WriteLine(String.Join(' ', sortedPeople));


            var personModels = GetPersonModels();
            foreach (var p in personModels)
            {
                Console.WriteLine($"Hello, {p.FirstName} {p.LastName}" );
            }


            Console.ReadLine();
        }

        public static List<string> GetPeople()
        {
            return new List<string>
            {
                "Adam",
                "Tim",
                "Mike",
                "John",
                "Jane",
                "Sue",
            };
        }
        public static List<PersonModel> GetPersonModels()
        {
            return new List<PersonModel>
            {
                new PersonModel{FirstName = "Tim", LastName ="Corey"},
                new PersonModel{FirstName = "Sue", LastName ="Storm"},
                new PersonModel{FirstName = "Mike", LastName ="Smith"},
                new PersonModel{FirstName = "Jane", LastName ="Mary"},
            };
        }
    }
}
