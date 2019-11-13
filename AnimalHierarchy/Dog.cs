﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, string sex) : base(name, age, sex)
        {

        }
        public void MakeASound()
        {
            Console.WriteLine("Woof Woof!!");
        }
    }
}