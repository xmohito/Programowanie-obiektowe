using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    class Buyer : Person
    {
        protected List<Product> products = new List<Product>();
        public Buyer(string name, int age) : base(name, age)
        {

        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            this.products.RemoveAt(index);
        }


        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Buyer: " + this.name + " (" + this.age.ToString() + " y.o.)");
            if (products.Count > 0)
            {
                Console.WriteLine(prefix + "\t -- Products: --");
                foreach (var p in products)
                {
                    p.Print(prefix + "\t");
                }
            }
        }
    }
}
