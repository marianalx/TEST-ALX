using Dziedziczenie.Figury;
using Dziedziczenie.KlasaAbstrakcyjna;
using Dziedziczenie.Przeciazanie;
using Dziedziczenie.Samochody;
using Dziedziczenie.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat(2.5, 3);
            double pole = prostokat.ObliczPole();
            Console.WriteLine("Pole prostokata={0}", pole);

            Kwadrat kwadrat = new Kwadrat(5);
            pole = kwadrat.ObliczPole();
            Console.WriteLine("Pole kwadratu={0}", pole);
            Console.WriteLine("Czy kwadrat={0}", kwadrat.CzyKwadrat());

            Trojkat trojkat = new Trojkat(10, 3);
            pole = trojkat.ObliczPole();
            double obwod = trojkat.ObliczObwod();
            Console.WriteLine("Pole trojkata={0}, a obwod={1}", pole, obwod);

            int localMax = Utils.GetMaxValue(10, -1, 30, -20);
            Console.WriteLine("wart maks={0}", localMax);

            Samochod pojazd = new Samochod();
            pojazd.Uruchom();

            Product product = new Product("chleb", 3.99);
            product.ShowInfo();
            product.ShowPrice();

            Wektor wektor1 = new Wektor(-1, 5);
            Wektor wektor2 = new Wektor(1, -5);
            Wektor wektor_res = wektor1.Add(wektor2);
            wektor_res.Print();

            wektor_res = wektor1 + wektor2;
            wektor_res.Print();

            wektor_res = wektor1 + 3.5;
            wektor_res.Print();

            Console.ReadKey();
        }
    }
}
