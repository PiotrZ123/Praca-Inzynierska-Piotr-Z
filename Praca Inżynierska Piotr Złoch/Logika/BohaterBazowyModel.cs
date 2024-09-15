using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public class BohaterBazowyModel
    {
        public bool Nieosobowy { get; set; }
        public string Imie { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int Maksymalna_ilosc_ruchu { get; set; }
        public int Ilosc_ruchu { get; set; }
    }
}
