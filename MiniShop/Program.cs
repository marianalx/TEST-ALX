using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prMaseczka = new Product(1, "Maseczka", 4.99);
            Product prPapier = new Product(2, "Papier toaletowy", 14.99, "3 grube warstwy");
            Product prRyz = new Product(3, "Ryż", 2.99);

            Order order = new Order();
            order.AddProduct(prMaseczka, 10);
            order.AddProduct(prRyz, 5);
            order.AddProduct(prPapier, 2);
            order.AddProduct(prMaseczka, 10);
            order.RemoveProduct(prRyz, 3);
            order.RemoveProduct(prPapier);

            order.Print();
            Console.ReadKey();
        }
    }
}
