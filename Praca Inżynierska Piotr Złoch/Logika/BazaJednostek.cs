using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public static class BazaJednostek
    {

        private static int DajPrzyrost(int numer)
        {
            if (numer >= 0 && numer <= 3) { return 20; }//ustaw przyrost jednostkom 1 poziomu
            if (numer >= 4 && numer <= 7) { return 10; }//ustaw przyrost jednostkom 2 poziomu
            if (numer >= 8 && numer <= 11) { return 6; }//ustaw przyrost jednostkom 3 poziomu
            if (numer >= 12 && numer <= 15) { return 3; }//ustaw przyrost jednostkom 4 poziomu
            if (numer >= 16 && numer <= 19) { return 1; }//ustaw przyrost jednostkom 5 poziomu
            return 0;
        }

        public static Jednostka dajPoNumerze(Gracz wlasciciel, int numer, int ilosc)
        {
            Jednostka jednostka = dajPoNumerzeBezPrzyrostu(wlasciciel, numer);
            jednostka.Przyrost = DajPrzyrost(numer);
            jednostka.Ilosc = ilosc;
            return jednostka;
        }

        private static Jednostka dajPoNumerzeBezPrzyrostu(Gracz wlasciciel, int numer)
        {
            Jednostka jednostka = new Jednostka();
            switch (numer)
            { 
                case 0: jednostka = new Jednostka(wlasciciel, 0, 20, 5, 2, 2, 1, 2, 4, 1, 0, false, Obrazy.GetJednostkaPortret("j1_1")); return jednostka;
                case 1: jednostka = new Jednostka(wlasciciel, 1, 25, 5, 4, 4, 1, 2, 5, 1, 0, false, Obrazy.GetJednostkaPortret("j1_2")); return jednostka;
                case 2: jednostka = new Jednostka(wlasciciel, 2, 30, 6, 6, 5, 1, 3, 5, 1, 0, false, Obrazy.GetJednostkaPortret("j1_3")); return jednostka;
                case 3: jednostka = new Jednostka(wlasciciel, 3, 35, 8, 8, 5, 1, 3, 6, 1, 0, false, Obrazy.GetJednostkaPortret("j1_4")); return jednostka;//jednostki 1 poziomu kończą się
                case 4: jednostka = new Jednostka(wlasciciel, 4, 50, 25, 10, 6, 3, 6, 5, 1, 0, false, Obrazy.GetJednostkaPortret("j2_1")); return jednostka;
                case 5: jednostka = new Jednostka(wlasciciel, 5, 60, 25, 12, 8, 3, 7, 5, 1, 0, false, Obrazy.GetJednostkaPortret("j2_2")); return jednostka;
                case 6: jednostka = new Jednostka(wlasciciel, 6, 60, 30, 12, 8, 4, 7, 6, 1, 0, false, Obrazy.GetJednostkaPortret("j2_3")); return jednostka;
                case 7: jednostka = new Jednostka(wlasciciel, 7, 60, 30, 13, 9, 5, 7, 6, 1, 0, false, Obrazy.GetJednostkaPortret("j2_4")); return jednostka;//koniec jednostek 2 poziomu
                case 8: jednostka = new Jednostka(wlasciciel, 8, 100, 20, 12, 2, 4, 8, 5, 1, 2, true, Obrazy.GetJednostkaPortret("j3_1")); return jednostka;
                case 9: jednostka = new Jednostka(wlasciciel, 9, 100, 20, 13, 2, 4, 8, 5, 1, 4, true, Obrazy.GetJednostkaPortret("j3_2")); return jednostka;
                case 10: jednostka = new Jednostka(wlasciciel, 10, 100, 20, 14, 2, 4, 8, 5, 1, 6, true, Obrazy.GetJednostkaPortret("j3_3")); return jednostka;
                case 11: jednostka = new Jednostka(wlasciciel, 11, 100, 20, 16, 2, 4, 8, 6, 1, 8, true, Obrazy.GetJednostkaPortret("j3_4")); return jednostka; // koniec jednostek 3 poziomu
                case 12: jednostka = new Jednostka(wlasciciel, 12, 400, 80, 18, 14, 8, 10, 8, 1, 0, false, Obrazy.GetJednostkaPortret("j4_1")); return jednostka;
                case 13: jednostka = new Jednostka(wlasciciel, 13, 450, 100, 19, 15, 10, 12, 8, 1, 0, false, Obrazy.GetJednostkaPortret("j4_2")); return jednostka;
                case 14: jednostka = new Jednostka(wlasciciel, 14, 500, 120, 20, 16, 10, 14, 10, 1, 0, false, Obrazy.GetJednostkaPortret("j4_3")); return jednostka;
                case 15: jednostka = new Jednostka(wlasciciel, 15, 600, 150, 22, 18, 12, 16, 12, 1, 0, false, Obrazy.GetJednostkaPortret("j4_4")); return jednostka; // koniec jednostek 4 poziomu
                case 16: jednostka = new Jednostka(wlasciciel, 16, 2500, 350, 35, 30, 40, 40, 18, 1, 0, false, Obrazy.GetJednostkaPortret("j5_1")); return jednostka;
                case 17: jednostka = new Jednostka(wlasciciel, 17, 3000, 350, 40, 35, 40, 40, 20, 1, 0, false, Obrazy.GetJednostkaPortret("j5_2")); return jednostka;
                case 18: jednostka = new Jednostka(wlasciciel, 18, 3500, 400, 40, 40, 45, 45, 22, 1, 0, false, Obrazy.GetJednostkaPortret("j5_3")); return jednostka;
                case 19:jednostka = new Jednostka(wlasciciel, 19, 4000, 500, 60, 60, 50, 50, 26, 1, 0, false, Obrazy.GetJednostkaPortret("j5_4")); return jednostka;//koniec jednostkek 5 poziomu
                default:jednostka = new Jednostka(wlasciciel, 0, 20, 5, 2, 2, 1, 2, 4, 1, 0, false, Obrazy.GetJednostkaPortret("j1_1")); return jednostka;
            }
        }
    }
}
