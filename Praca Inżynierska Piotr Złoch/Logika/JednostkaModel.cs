using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public class JednostkaModel
    {
        public int Przyrost { get; set; }
        public int Numer { get; set; }

        public int Ilosc { get; set; }

        public int Koszt { get; set; }

        //public int ZycieAktualne { get; set; }

        public int Zycie_max { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int Obrazenia_min { get; set; }
        public int Obrazenia_max { get; set; }

        public int Kontratak { get; set; }
        public int Ilosc_strzal { get; set; }

        public int Szybkosc { get; set; }
        public bool Strzela { get; set; }
    }
}
