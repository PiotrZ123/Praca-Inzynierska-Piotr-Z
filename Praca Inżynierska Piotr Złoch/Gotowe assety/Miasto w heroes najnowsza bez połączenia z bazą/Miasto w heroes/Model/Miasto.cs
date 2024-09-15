using Miasto_w_heroes.Model;
using Miasto_w_heroes.Services;
using ModelDanych.Bazowy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    public class Miasto: MiastoBazowyModel, ObiektNaMapie, ObiektWlasciciela
    {
        public int Id { get; set; }
        public Gracz Wlasciciel
        {
            get
            {
                if(WlascicielGuid=="")
                {
                    return null;
                }
                return Gra.DajInstancje().Mapa.DajWlasiciela(WlascicielGuid);
            }
            set
            {
                if(value==null)
                {
                    WlascicielGuid = "";
                }
                else
                {
                    WlascicielGuid = value.NumerGuid;
                }
                
            }
        }

        public string WlascicielGuid { get; set; }

        public Bohater BohaterWMiescie { get; set; }
        
        public Jednostka[] JednostkaDoRekrutacji { get; set; }

        public Budynek[] Budynki { get; set; }
        public Miasto()
        {
            JednostkaDoRekrutacji = new Jednostka[5];
            for (int i = 0; i < JednostkaDoRekrutacji.Length; i++)
            {
                JednostkaDoRekrutacji[i] = new Jednostka();
            }

            BohaterWMiescie = new Bohater();
            Budynki = new Budynek[10];
            for(int i=0; i<Budynki.Length; i++)
            {
                Budynki[i] = new Budynek();
            }


        }

        public Miasto(int x, int y,Gracz wlasciciel)
        {
            Budynki = new Budynek[10];
            
            Wlasciciel = wlasciciel;
            JednostkaDoRekrutacji = new Jednostka[5];
            BohaterWMiescie = new Bohater();
            Przychod = 500;
            this.PolozenieX = x;
            this.PolozenieY = y;
            for (int i=0; i< Budynki.Length; i++)
            {
                Budynki[i] = new Budynek();
                Budynki[i].Poziom = 0;
                Budynki[i].Cena = 2000 + i * (500);
            }
        }
        public bool CzyMoznaUpgradowacJednostkeNaPodstawieNumeru(int numer)
        {
            int i = numer / 4;
            if ((i*4)+Budynki[i].Poziom -2 >= numer&& (i * 4) + Budynki[i].Poziom - 2 <= numer+3) { return true; }
            return false;
        }
        public int Budowa_budynku(int i, BazaJednostek bazaJednostek)
        {
            if (i >= 0 && i <= 9)
            {
                if (Budynki[i].Poziom >= 0 & Budynki[i].Poziom <= 5 & Czy_mozna_budowac > 0)
                {
                    Budynki[i].Poziom++;
                    Jednostka jednostka = new Jednostka(Wlasciciel, 0, 20, 20, 5, 2, 2, 1, 2, 1, 0, false, Properties.Resources.j1_1);
                    if (i <= 4 && Budynki[i].Poziom == 1) 
                    {
                        JednostkaDoRekrutacji[i] = new Jednostka();
                        JednostkaDoRekrutacji[i] = bazaJednostek.dajPoNumerze(Wlasciciel,4*i + (Budynki[i].Poziom - 1) ); 
                    }
                    else if (i <= 4 && Budynki[i].Poziom >= 2 && Budynki[i].Poziom <= 4)
                    {
                        JednostkaDoRekrutacji[i].UpgradeJednostki();
                        //int przyrost_bufor = JednostkaDoRekrutacji[i].Przyrost;
                        //JednostkaDoRekrutacji[i] = bazaJednostek.dajPoNumerzeBezPrzyrostu(Wlasciciel, 4 * i + (Budynki[i].Poziom - 1));
                        //JednostkaDoRekrutacji[i].Przyrost = przyrost_bufor;
                    }
                    else if (i == 9)
                    {
                        Przychod += 500;
                    }
                    Czy_mozna_budowac--;

                    return 1;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public bool Czy_puste()
        {
            int i = 0;
            while (i < 5)
            {
                if (BohaterWMiescie.Jednostki[i] != null)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
      
        public void Wloz_jednostke_po_numerze_slotu(int numer, Jednostka jednostka1)
        {
            BohaterWMiescie.Jednostki[numer] = jednostka1;

        }

        public void Dodaj_przyrost_jednostki()
        {
            int i = 0;
            Jednostka jednostka1;
            while (i <= 4)
            {
                if (Budynki[i].Poziom >= 1)
                {

                    jednostka1 = JednostkaDoRekrutacji[i];
                    int przyrost_bufor = jednostka1.Przyrost;
                    jednostka1.Przyrost = przyrost_bufor + Gra.DajInstancje().BazaJednostek.DajPrzyrost(jednostka1.Numer);
                }
                i++;
            }
        }

        public void Rysuj(Graphics grafika)
        {
            Gracz wlasciciel = Wlasciciel;
            string kolor = "bez_koloru";
            if (wlasciciel != null)
            {
                kolor = wlasciciel.Kolor;
            }
            
            Image imgNew = Obrazy.GetMiasto(kolor);
            grafika.DrawImage(imgNew, (PolozenieX * 40 - 40), (PolozenieY * 40 - 40), 120, 80);
        }

        public Jednostka Oddaj_jednostke_do_rekrutacji_po_numerze_budynku(int numer)
        {
            return JednostkaDoRekrutacji[numer];
        }
        public void Czy_mozna_budowac_tak()
        {
                Czy_mozna_budowac = Maksymalna_ilosc_budynkow_do_zbudowania_na_ture;
        }

        public int Sprawdzenie_budynku(int i)
        {
            if (Budynki[i].Poziom == 0)
            {
                return 1;
            }
            else if (Budynki[i].Poziom == 1)
            {
                return 2;
            }
            else if (Budynki[i].Poziom == 2)
            {
                return 3;
            }
            else if (Budynki[i].Poziom == 3)
            {
                return 4;
            }
            else if (Budynki[i].Poziom == 4)
            {
                return 5;
            }
            else return 0;
        }

        public Jednostka Oddaj_jednostke_po_numerze_slotu(int numer_slotu)
        {
            if (0  <= numer_slotu && numer_slotu < 5)
            {
                return BohaterWMiescie.Jednostki[numer_slotu];
            }
            return null;
        }

        public bool UstawJednosteDoMiasta(Jednostka jednostka, int ilosc)
        {
            for(int i = 0; i < 5; i++)
            {
                if (BohaterWMiescie.Jednostki[i] == null)
                {
                    BohaterWMiescie.Jednostki[i] = Gra.DajInstancje().BazaJednostek.dajPoNumerze(Wlasciciel,jednostka.Numer);
                    BohaterWMiescie.Jednostki[i].Ilosc = ilosc;
                    return true;
                }
                else if (BohaterWMiescie.Jednostki[i].Numer == jednostka.Numer)
                {
                    BohaterWMiescie.Jednostki[i].Ilosc += ilosc;
                    return true;
                }
            }
            return false;
        }

        public string Podaj_imie_aktualnego_wlasciciela()
        {
            if (Wlasciciel != null)
            {
                return Wlasciciel.Imie;
            }
            return "";
        }
        public int Podaj_cene_budynku(int i)
        {
            return Budynki[i].Cena;
        }

        public void Daj_przychod_dla_wlasciciela()
        {
            if (Wlasciciel != null)
            {
                Wlasciciel.Zloto+=Przychod;
            }
        }

        public void Interakcja(Bohater bohater)
        {
            if(Wlasciciel != bohater.Wlasciciel)
            {
                Wlasciciel = bohater.Wlasciciel;
            }
            
            Miasto_widok miasto = new Miasto_widok(this);
            miasto.Inicjalizuj(bohater);
            miasto.ShowDialog();
        }

        public void AkcjaPoKliknieciu(Gra gra)
        {
            if(gra.AktualnyGracz(Wlasciciel))
            {
                Miasto_widok miasto = new Miasto_widok(this);
                miasto.Inicjalizuj(null);
                miasto.ShowDialog();
            }
        }
    }
}
