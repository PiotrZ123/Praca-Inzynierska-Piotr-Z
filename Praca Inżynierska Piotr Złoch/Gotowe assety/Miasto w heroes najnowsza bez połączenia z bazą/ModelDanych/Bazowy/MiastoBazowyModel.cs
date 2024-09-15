using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych.Bazowy
{
    public class MiastoBazowyModel : BazowyModel
    {
        public string WlascicielGuid { get; set; }
        
        public int Maksymalna_ilosc_budynkow_do_zbudowania_na_ture { get; set; }
        public int Czy_mozna_budowac { get; set; }
        public int Przychod { get; set; }
       
        public MiastoBazowyModel()
        {
            Maksymalna_ilosc_budynkow_do_zbudowania_na_ture = 2;
            Czy_mozna_budowac = 2;
            Przychod = 500;
        }

    }
}
