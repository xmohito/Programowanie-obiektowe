using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    class Shop
    {
        private string name;
        private Person[] people;
        private Product[] products;

        public string Name
        {
            get { return name; }
        }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine("Shop: " + this.name);
            Console.WriteLine("-- People: --");
            foreach (var p in people)
            {
                p.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (var p in products)
            {
                p.Print("\t");
            }

        }
    }

}
