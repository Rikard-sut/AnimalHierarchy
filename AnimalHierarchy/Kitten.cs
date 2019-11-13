using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        override public string Sex
        {
            get { return this.Sex; }
        }
        public Kitten(string name, int age, string sex = "Female") : base(name, age, sex)
        {

        }
        override public void MakeASound()
        {
            Console.WriteLine("Meeeeaaaaaoooooooooowwwwwwwww");
        }
    }
}