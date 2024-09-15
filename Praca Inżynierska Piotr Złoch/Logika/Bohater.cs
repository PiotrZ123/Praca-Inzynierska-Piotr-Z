using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praca_Inżynierska_Piotr_Złoch.Logika;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public class Bohater : BohaterBazowyModel
    {
        private Gracz wlasciciel;
        public Gracz Wlasciciel { 
            get
            {
                return wlasciciel;
            }
            set
            {
                wlasciciel = value;
            }
        }

        private Image portret;
        public Image Portret {
            get
            {
                if(portret==null)
                {
                    portret = Obrazy.GetBohaterPortret(this.Imie);
                }
                return portret;
            }
        }

        public Jednostka[] Jednostki { get; set; } 
     
        public Bohater(int atak, int obrona,Gracz Wlasciciel1) 
        {
            Imie = "Tadek";
            Atak = atak;
            Obrona = obrona;
            Nieosobowy = false;
            wlasciciel = Wlasciciel1;
            Maksymalna_ilosc_ruchu = 1000;
            Jednostki = new Jednostka[10];
        }

        public Bohater(Gracz Wlasciciel1)
        {
            wlasciciel = Wlasciciel1;
            Imie = "";
            Atak = 1;
            Obrona = 1;
            Nieosobowy = true;
            Maksymalna_ilosc_ruchu = 1000;
            Jednostki = new Jednostka[10];
            Jednostki[0] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[1] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[2] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[3] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[4] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[5] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[6] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[7] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[8] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
            Jednostki[9] = BazaJednostek.dajPoNumerze(wlasciciel, 0,10);
        }

        public bool MaTylkoJedenTypJednostek()
        {
            int ilosc = 0;
            for(int i=0; i<Jednostki.Length; i++)
            {
                if(Jednostki[i]!=null && Jednostki[i].Ilosc>0)
                {
                    ilosc++;
                }
            }
            return ilosc==1;
        }

        public List<Jednostka> OddajListeJednostek()
        {
            List <Jednostka> jednostki1 = new List<Jednostka>();
            foreach (Jednostka jednostka in Jednostki)
            {
                if (jednostka != null) { jednostki1.Add(jednostka); }
            }
            return jednostki1;
        }
        public bool czy_ma_jednostki()
        {
            int i = 0;
            while (i < Jednostki.Length)
            {
                if (Jednostki[i] != null && Jednostki[i].Ilosc >= 1)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
             
        public void dodaj_jednostke(Jednostka jednostka1, int numer_slotu)
        {

            Jednostki[numer_slotu] = jednostka1;
            if (Jednostki[numer_slotu] != null)
            {
                if (Jednostki[numer_slotu].Ilosc <= 0)
                {
                    Jednostki[numer_slotu].Ilosc=1;
                }
            }
        }
        public void SprzedajJednostkeZeSlotu(int numer_slotu)
        {
            if (Jednostki[numer_slotu] != null)
            {
                Wlasciciel.Zloto += Jednostki[numer_slotu].ZwrocCalkoityKoszt();
                Jednostki[numer_slotu] = null;
            }
        }
       

        public Jednostka DajJednostke(int numer_slotu)
        {
            return Jednostki[numer_slotu];
        }
    }
}
