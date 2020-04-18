using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    public class Prostokat : Figura
    {
        protected double bokA;
        protected double bokB;

        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            liczbaBokow = 2;
            Console.WriteLine("Kontruktor klasy Prostokat");
        }

        public double ObliczPole()
        {
            return bokA * bokB;
        }

        public bool CzyKwadrat()
        {
            return bokA == bokB;
        }
    }
}
