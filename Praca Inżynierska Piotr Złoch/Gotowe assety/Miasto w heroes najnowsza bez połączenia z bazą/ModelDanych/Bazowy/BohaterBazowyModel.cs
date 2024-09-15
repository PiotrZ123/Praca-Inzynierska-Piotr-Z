using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych.Bazowy
{
    public class BohaterBazowyModel : BazowyModel
    {
        public string WlascicielGuid { get; set; }
        public bool Nieosobowy { get; set; }
        public string Imie { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int Maksymalna_ilosc_ruchu { get; set; }
        public int Ilosc_ruchu { get; set; }
    }
}
