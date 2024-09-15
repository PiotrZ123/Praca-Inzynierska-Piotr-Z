using Miasto_w_heroes.Model;
using ModelDanych;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animacje;

namespace Miasto_w_heroes.Model
{
    public class Jednostka : JednostkaModel
    {
        public Gracz Wlasciciel
        {
            get
            {
                return Gra.DajInstancje().Mapa.DajWlasiciela(WlascicielGuid);
            }
            set
            {
                WlascicielGuid = value.NumerGuid;
            }
        }

        public void PrzywrocPortret()
        {
            BazaJednostek baza = new BazaJednostek();
            Gracz gracz = new Gracz();
            Jednostka jednostka = baza.dajPoNumerze(gracz, Numer);
            Portret = jednostka.Portret;
        }

        public string WlascicielGuid { get; set; }

        int bitwa_lokalizacja_x;
        int bitwa_lokalizacja_y;


        public Jednostka(Gracz wlasciciel, int numer, int koszt, int zycie_max, int atak, int obrona, int obrazenia_min, int obrazenia_max, int szybkosc, int kontratak, int ilosc_strzal, bool strzela, Image portret)
        {
            Szybkosc = 5;
            Wlasciciel = wlasciciel;
            Numer = numer;
            Koszt = koszt;
            Zycie_max = zycie_max;
            Atak = atak;
            Obrona = obrona;
            Obrazenia_min = obrazenia_min;
            Obrazenia_max = obrazenia_max;
            Szybkosc = szybkosc;
            Kontratak = kontratak;
            Ilosc_strzal = ilosc_strzal;
            Strzela = strzela;

            Zycie_aktualne = zycie_max;
            Portret = portret;
        }

        public Jednostka()//TYLKO do jednostek tymczasowych
        {
            Szybkosc = 5;
        }

        public Image Portret { get; set; }

        public int Zycie_aktualne { get; set; }

        public void ustaw_lokalizacje_jednostki(int x, int y)
        {
            bitwa_lokalizacja_x = x;
            bitwa_lokalizacja_y = y;
        }

        public int X
        {
            get => bitwa_lokalizacja_x;
            //set => bitwa_lokalizacja_x = value;
        }
        public int Y
        {
            get => bitwa_lokalizacja_y;
            //set => bitwa_lokalizacja_y = value;
        }

        public bool sprawdz_czy_ta_sama_po_numerze(int numer1, int numer2)
        {
            if (numer1 == numer2)
            {
                return true;
            }
            else
                return false;
        }

        public Jednostka polacz_takie_same(Jednostka jednostka1, Jednostka jednostka2)
        {
            if (jednostka1.Numer == jednostka2.Numer)
            {
                int bufor;
                bufor = jednostka1.Ilosc + jednostka2.Ilosc;
                jednostka1.Ilosc = bufor;
                return jednostka1;
            }
            return null;
        }

        public void otrzymywanie_obrazen(int obrazenia)
        {
            int zycie_cale= Zycie_max * Ilosc-1 + Zycie_aktualne;
            zycie_cale = zycie_cale - obrazenia;
            if (zycie_cale <= 0)
            {
                Ilosc = 0;
            }
            else
            {
                Ilosc = zycie_cale / Zycie_max;
                if(zycie_cale < Zycie_max)
                {
                    Ilosc = 1;
                }
                Zycie_aktualne = zycie_cale % Zycie_max;
                //if (ZycieAktualne == 0) { Ilosc -= 1;Zycie_aktualne = Zycie_max; }

            }
            
        }
        private bool SprawdzUpgrade(int numerJednostki)
        {
            if (numerJednostki < 0 || numerJednostki > 19)
                return false;

            if (numerJednostki < 3)
                return true;
            else if (numerJednostki < 7)
                return true;
            else if (numerJednostki < 11)
                return true;
            else if (numerJednostki < 15)
                return true;
            else if (numerJednostki < 19)
                return true;
            else
                return false;
        }

        private bool SprawdzDegradacje(int numerJednostki)
        {
            if (numerJednostki < 0 || numerJednostki > 19)
                return false;

            if (numerJednostki > 0&& numerJednostki < 4)
                return true;
            else if (numerJednostki > 4 && numerJednostki < 8)
                return true;
            else if (numerJednostki > 8 && numerJednostki < 12)
                return true;
            else if (numerJednostki > 12 && numerJednostki < 16)
                return true;
            else if (numerJednostki > 16 && numerJednostki < 20)
                return true;
            else
                return false;
        }

        public void NadpiszJednostkeInnaZBazy(int numer)
        {
            BazaJednostek baza = new BazaJednostek();
            Jednostka jednostka = baza.dajPoNumerze(Wlasciciel,numer);
            Szybkosc = 5;
            Wlasciciel = jednostka.Wlasciciel;
            Numer = jednostka.Numer;
            Koszt = jednostka.Koszt;
            Zycie_max = jednostka.Zycie_max;
            Atak = jednostka.Atak;
            Obrona = jednostka.Obrona;
            Obrazenia_min = jednostka.Obrazenia_min;
            Obrazenia_max = jednostka.Obrazenia_max;
            Szybkosc = jednostka.Szybkosc;
            Kontratak = jednostka.Kontratak;
            Ilosc_strzal = jednostka.Ilosc_strzal;
            Strzela = jednostka.Strzela;
            Zycie_aktualne = jednostka.Zycie_max;
            Portret = jednostka.Portret;
        }

        public void UpgradeJednostki()
        {
            BazaJednostek baza = new BazaJednostek();
            Jednostka jednostka = baza.dajPoNumerze(Wlasciciel, Numer+1);
            int Cena = (Ilosc * jednostka.Koszt) - (Ilosc * Koszt);
            if (SprawdzUpgrade(Numer) == true&& Wlasciciel.Zloto >= Koszt)
            {
                Wlasciciel.Zloto -= Cena;
                NadpiszJednostkeInnaZBazy(Numer+1);
            }
        }

        public void DegradajcaJednostki()
        {
            if (SprawdzDegradacje(Numer) == true)
            {
                NadpiszJednostkeInnaZBazy(Numer - 1);
            }
        }

        public void RysujBitwa(Graphics g)
        {
            g.DrawImage(Portret, Y * 50 + 100, 50 * X, 50, 50);
        }
        public void atak_jednostki(Jednostka jednostka_zaatakowana, int atak_bohatera_atakujacego, int obrona_bohatera_broniacego)
        {
            int atak1 = atak_bohatera_atakujacego + Atak;
            int obrona1 = obrona_bohatera_broniacego + jednostka_zaatakowana.Obrona;

            Random rnd = new Random();
            int obrazenia = 0;

            int i = 0;
            while (i < Ilosc)
            {
                obrazenia = obrazenia + rnd.Next(Obrazenia_min, Obrazenia_max + 1);
                i++;
            }
            int modyfikator = atak1 - obrona1;
            if (modyfikator >= 30)
            {
                modyfikator = 30;
            }
            if (modyfikator <= -9)
            {
                modyfikator = -9;
            }
            int obrazenia_ostateczne = obrazenia + (modyfikator * obrazenia)/10;
            if (obrazenia_ostateczne <1)
            {
                obrazenia_ostateczne = 1;
            }
            jednostka_zaatakowana.otrzymywanie_obrazen(obrazenia_ostateczne);
        }

    }
}
