using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        override public string Sex
        {
            get { return this.Sex; }
        }
        public Tomcat(string name, int age, string sex = "Male") :base(name, age, sex)
        {

        }
        override public void MakeASound()
        {
            Console.WriteLine("GrrrereeMeow");
        }
    }
}