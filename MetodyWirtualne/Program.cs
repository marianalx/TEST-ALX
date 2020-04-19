using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyWirtualne
{
    class Program
    {
        static void Main(string[] args)
        {
            String napis = "Ala ma kota";
            Console.WriteLine(napis);

            Double liczba = 12.34;
            Console.WriteLine(liczba); 

            Kot kot = new Kot();
            Console.WriteLine(kot);

            Console.ReadKey();
        }
    }
}
