using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 200);
            //samochod.UstawPredkoscMax(250);
            samochod.PredkoscMax = -10;
            //int predkosc = samochod.PodajPredkoscMax();
            int predkosc = samochod.PredkoscMax;
            Console.WriteLine("Predkosc maks = {0}", predkosc);
            Console.ReadKey();
        }
    }
}
