using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    abstract class Person : IThing
    {
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        protected string name;
        protected int age;
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }

        public bool Equals(Person obj)
        {
            return obj.name == this.name && obj.age == this.age;
        }

        public abstract void Print(string prefix);

    }
}
