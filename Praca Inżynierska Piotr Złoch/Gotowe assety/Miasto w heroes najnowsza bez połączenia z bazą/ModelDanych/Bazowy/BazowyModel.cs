using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDanych.Bazowy
{
    public class BazowyModel
    {
        public BazowyModel()
        {
            PolozenieX = 0;
            PolozenieY = 0;
        }


        public int PolozenieX { get; set; }
        public int PolozenieY { get; set; }

        public int Szerokosc { get; set; }
        public int Wysokosc { get; set; }
    }
}
