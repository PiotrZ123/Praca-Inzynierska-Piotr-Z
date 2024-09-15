using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    interface RysowanieAnimacji
    {
        void WykonajAnimacjeAtakuJednostki(Jednostka jednostka);
        void WykonajAnimacjeSmierciJednostki(Jednostka jednostka);
    }
}
