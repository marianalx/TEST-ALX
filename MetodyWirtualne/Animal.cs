using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyWirtualne
{
    class Ssak
    {
        public void Karmienie()
        {
            Console.WriteLine("Operacja karmienia");
        }

    }

    class Kot : Ssak
    {
        public new void Karmienie()
        {
            Console.WriteLine("Kot - karmienie");
        }

        public void DajGlos()
        {

        }

        public override string ToString()
        {
            return "Obiekt klasy Kot";
        }
    }

}
