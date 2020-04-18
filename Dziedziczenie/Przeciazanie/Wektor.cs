using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Przeciazanie
{
    class Wektor
    {
        private double x;
        private double y;
        private double z;

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public double Z { get; }

        public Wektor(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public Wektor Add(Wektor w)
        {
            return new Wektor(x + w.X, y + w.Y);
        }

        public void Print()
        {
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        public static Wektor operator +(Wektor w1, Wektor w2)
        {
            return new Wektor(w1.X + w2.X, w1.Y + w2.Y);
        }

        public static Wektor operator +(Wektor w1, double liczba)
        {
            return new Wektor(w1.X + liczba, w1.Y + liczba);
        }

    }
}
