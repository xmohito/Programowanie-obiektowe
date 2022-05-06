using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {

        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Seller: " + this.name + " (" + this.age.ToString() + " y.o.)");
        }
    }
}
