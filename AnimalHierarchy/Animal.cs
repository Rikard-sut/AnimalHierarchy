using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Animal :ISound
    {
        private string name;
        private int age = 0;
        private Gender sex;

        public Animal(string name, int age, Gender sex)
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
        public Gender Sex
        {
            get { return this.sex; }
            set{ this.sex = value; }
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Name: {0} Age:{1} Gender: {2} ", this.name, this.age, this.sex);
            return info.ToString();
        }
        public static float CalcAverageAge(Animal[] item)
        {
            float totalAge = 0;
            for (int i = 0; i < item.Length; i++)
            {
                totalAge = totalAge + item[i].Age;
            }
            return totalAge / item.Length;

        }
        public virtual void MakeASound()
        {
            Console.WriteLine("Zzzzz");
        }


    }
}