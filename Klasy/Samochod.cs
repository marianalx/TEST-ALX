using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    public class Samochod
    {
        private String marka;
        private int predkoscMax;

        public int PredkoscMax
        {
            get { return predkoscMax; }
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Prędkość musi być > 0");
                }
                else
                {
                    predkoscMax = value;
                }
            }
        }

        public int LiczbaDrzwi { get; set; }

        public Samochod(string marka, int predkoscMax)
        {
            this.marka = marka;
            this.predkoscMax = predkoscMax;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }

        public void UstawPredkoscMax(int predkosc)
        {
            predkoscMax = predkosc;
        }

    }
}
