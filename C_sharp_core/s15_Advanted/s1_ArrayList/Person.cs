using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1_ArrayList
{
    internal class Person
    {
        private string Name;
        private int Age;

        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

        // tao constructor
        public Person() { }
         
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return " Name :" + Name + " | Age : " + Age;
        }
    }
}
