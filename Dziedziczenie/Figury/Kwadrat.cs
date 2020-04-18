using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    public class Kwadrat : Prostokat
    {
        public Kwadrat(double bok) : base(bok, bok)
        {
            Console.WriteLine("Kontruktor klasy Kwadrat");
        }

        public bool CzyKwadrat()
        {
            return base.CzyKwadrat();

        }

    }
}
