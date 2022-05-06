using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    abstract class Product : IThing
    {
        public Product(string name)
        {
            this.name = name;

        }
        protected string name;

        public string Name
        {
            get { return name; }
        }


        public abstract void Print(string prefix);
    }
}
