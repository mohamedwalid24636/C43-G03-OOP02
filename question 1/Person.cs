using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    internal class Person
    {
        public string name { set; get; } 
        public int age { set; get; }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"name = {name}, age = {age}";
        }

    }
}
