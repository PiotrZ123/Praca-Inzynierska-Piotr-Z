using Miasto_w_heroes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes
{
    public class BazaBohaterow
    {
        private Bohater[] bohaterowie;
        private int index;
        private BazaJednostek bazaJednostek;
        
        public BazaBohaterow(int index, BazaJednostek bazaJednostek)
        {
            this.index = index;
            this.bazaJednostek = bazaJednostek;
            bohaterowie = new Bohater[10];
            bohaterowie[0] = new Bohater("Janek", 40, 0);
            bohaterowie[1] = new Bohater("Wacek", 2, 2);
            bohaterowie[2] = new Bohater("Adam", 18, 2);
            bohaterowie[3] = new Bohater("Mietek", 15, 12);
            bohaterowie[4] = new Bohater("Zenek", 13, 2);
            bohaterowie[5] = new Bohater("Janek1", 13, 32);
            bohaterowie[6] = new Bohater("Wacek1", 15, 32);
            bohaterowie[7] = new Bohater("Adam1", 18, 2);
            bohaterowie[8] = new Bohater("Mietek1", 15, 12);
            bohaterowie[9] = new Bohater("Zenek1", 13, 2);
        }

        public Bohater DajBohatera(Gracz wlasciciel, int polozenie_x, int polozenie_y)
        {
            Bohater bohater = bohaterowie[index];
            index++;
            bohater.Wlasciciel =wlasciciel;
            bohater.PolozenieX = polozenie_x;
            bohater.PolozenieY = polozenie_y;
            Jednostka jednostka_tymczasowa = new Jednostka();
            Jednostka jednostka = bazaJednostek.dajPoNumerzeBezPrzyrostu(wlasciciel, 0);
            //Jednostka jednostka = Jednostka.po_numerze_oddaj_jednostke_bez_przyrostu(wlasciciel, 0);
            jednostka.Ilosc+=9;
            bohater.dodaj_jednostke(jednostka, 0);
            return bohater;
        }

    }
}

