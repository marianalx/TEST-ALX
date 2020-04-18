using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    public class Trojkat : Figura, IFigura
    {
        private double? bokA = null;
        private double? bokB = null;
        private double? bokC = null;
        private double? wysokosc = null;

        private Int32? x;

        public Trojkat(double bokA, double bokB, double bokC)
        {
            this.bokA = bokA; this.bokB = bokB; this.bokC = bokC;
            liczbaBokow = 3;
            x = null;
        }

        public Trojkat(double bokA, double wysokosc)
        {
            this.bokA = bokA;
            this.wysokosc = wysokosc;
        }

        public double ObliczPole()
        {
            if (bokA!=null && wysokosc!=null)
            {
                return 0.5 * (double)bokA * (double)wysokosc;
            } else
            {
                double p = (double)(0.5 * (bokA + bokB + bokC));
                return Math.Sqrt(p * (p - (double)bokA) * (p - (double)bokB) * (p - (double)bokC));
            }
        }

        public double ObliczObwod()
        {
            if (wysokosc!=null)
            {
                return 0;
            } else
            {
                return (double)bokA + (double)bokB + (double)bokC;
            }  
        }
    }
}
