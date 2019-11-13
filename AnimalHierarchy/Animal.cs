using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Animal
    {
        private string name;
        private int age = 0;
        private string sex;

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.age = age;
            this.Sex = sex;

        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name cannot be null");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public virtual string Sex
        {
            get { return this.sex; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Sex cannot be null");
                this.sex = value;
            }
        }


    }
}