using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Samochody
{
    class Pojazd : IPojazd
    {
        protected int liczbaKol;
        protected int liczbaDrzwi;
        protected int maksPredkosc;
        protected bool czySilnikowy;

        public void Uruchom()
        {
            throw new NotImplementedException();
        }

        public void Zatankuj()
        {
            throw new NotImplementedException();
        }

        public void Zatrzymaj()
        {
            throw new NotImplementedException();
        }
    }
}
