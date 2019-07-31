using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5_ParallelLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person{Name = "Alan", City="Lisburn"},
                new Person{Name = "Steve", City="Bangor"},
                new Person{Name = "Eoghan", City="Omagh"},
                new Person{Name = "Siobhan", City="Enniskillen"},
                new Person{Name = "Laura", City="Dungannon"},
                new Person{Name = "Claire", City="Glengormley"},
                new Person{Name = "Simon", City="Belfast"},
                new Person{Name = "David", City="Holywood"},
                new Person{Name = "Sean", City="Derry"},
                new Person{Name = "Frank", City="Belfast"},
                new Person{Name = "Ciara", City="Newry"}
            };

            var result = from person in people.AsParallel()
                         where person.City == "Belfast"
                         select person;

            foreach (var person in result)
                Console.WriteLine("Person: " + person.Name);

            Console.WriteLine("Finished processing.");
            Console.ReadKey();
        }
    }
}
