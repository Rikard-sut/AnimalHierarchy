using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[5]
            {
                new Dog("Anders", 5, Gender.Male),
                new Dog("Anna", 6, Gender.Female),
                new Dog("Per", 4, Gender.Male),
                new Dog("Siv", 5, Gender.Female),
                new Dog("Rex", 7, Gender.Male)
            };
            Cat[] cats = new Cat[5]
            {
                new Tomcat("Kattentom",7),
                new Kitten("Mini", 4),
                new Tomcat("Pelle", 8),
                new Kitten("Lelle", 3),
                new Tomcat("Fels", 2)
            };
            Frog[] frogs = new Frog[5]
            {
                new Frog("Grodanboll", 2, Gender.Male),
                new Frog("Grodananna", 3, Gender.Female),
                new Frog("Grodanper", 2, Gender.Male),
                new Frog("Grodansiv", 1, Gender.Female),
                new Frog("Grodananders", 2, Gender.Male)
            };
            List<Animal> animals = new List<Animal>();
            animals.AddRange(dogs);
            animals.AddRange(cats);
            animals.AddRange(frogs);

            animals.OrderBy(animal => animal.Age);
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.MakeASound();
            }
            Console.ReadKey();

            Console.WriteLine("Average age of dogs: {0} years", Animal.CalcAverageAge(dogs));
            Console.WriteLine("Average age of cats: {0} years", Animal.CalcAverageAge(cats));
            Console.WriteLine("Average age of frogs: {0} years", Animal.CalcAverageAge(frogs));
            Console.ReadKey();
        }
    }
}
