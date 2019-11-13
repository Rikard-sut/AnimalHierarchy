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
                new Dog("Anders", 5, "Male"),
                new Dog("Anna", 6, "Female"),
                new Dog("Per", 4, "Male"),
                new Dog("Siv", 5, "Female"),
                new Dog("Rex", 7, "Male")
            };
            Cat[] cats = new Cat[5]
            {
                new Tomcat("Kattentom",10),
                new Kitten("Mini", 4),
                new Tomcat("Pelle", 8),
                new Kitten("Lelle", 3),
                new Tomcat("Fels", 2)
            };
            Frog[] frogs = new Frog[5]
            {
                new Frog("Grodanboll", 2, "Male"),
                new Frog("Grodananna", 3, "Female"),
                new Frog("Grodanper", 2, "Male"),
                new Frog("Grodansiv", 1, "Female"),
                new Frog("Grodananders", 2, "Male")
            };
            List<Animal> animals = new List<Animal>();
            animals.AddRange(dogs);
            animals.AddRange(cats);
            animals.AddRange(frogs);

            animals.OrderBy(animal => animal.Age);
            animals.ForEach(Console.WriteLine);
            Console.ReadKey();

            Console.WriteLine("Average age of dogs: {0} years", CalcAverageAge(dogs));
            Console.WriteLine("Average age of cats: {0} years", CalcAverageAge(cats));
            Console.WriteLine("Average age of frogs: {0} years", CalcAverageAge(frogs));
            Console.ReadKey();

            
        }
        public static float CalcAverageAge(Animal[] item)
        {
            int totalAge = 0;
            for (int i = 0; i < item.Length; i++)
            {
                totalAge = totalAge + item[i].Age;
            }
            return totalAge / item.Length;

        }

    }
}
