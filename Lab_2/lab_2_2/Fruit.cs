using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    class Fruit : Product

    {

        int count;

        public int Count { get { return count; } }
        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.name + " (" + this.count + " " + (this.count == 1 ? "fruit" : "fruits") + ")");
        }
    }
}
