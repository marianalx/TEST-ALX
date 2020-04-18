using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaAbstrakcyjna
{
    abstract class AbstractProduct
    {
        protected String name;
        protected double price;

        public AbstractProduct(String name, double price)
        {
            this.name = name; this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} - {1}", name, price);
        }

        public abstract void ShowPrice();

    }
}
