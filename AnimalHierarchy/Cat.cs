using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, string sex) :base(name, age, sex)
        {

        }
        public virtual void MakeASound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}