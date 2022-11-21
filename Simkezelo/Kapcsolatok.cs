using System;
using System.Collections.Generic;
using System.Text;

namespace Simkezelo
{
    class Kapcsolatok : KartyaSim
    {
        public string nev;
        public string telefon;
        public string email;
    }

    public void kapcsolatLetrehoz(string nev1, string telefon1, string email1)
    {
        nev1 = this.nev;
        telefon1 = this.telefon;
    }
}
