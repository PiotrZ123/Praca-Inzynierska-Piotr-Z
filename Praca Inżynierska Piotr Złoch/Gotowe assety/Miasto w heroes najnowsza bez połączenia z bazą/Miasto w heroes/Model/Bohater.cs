using Miasto_w_heroes.Services;
using ModelDanych;
using ModelDanych.Bazowy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miasto_w_heroes.Model
{
    public class Bohater : BohaterBazowyModel, ObiektNaMapie, ObiektWlasciciela
    {
        public int Id { get; set; }
        public Gracz Wlasciciel { 
            get
            {
                return Gra.DajInstancje().Mapa.DajWlasiciela(WlascicielGuid);
            }
            set
            {
                WlascicielGuid = value.NumerGuid;
            }
        }

        public string WlascicielGuid { get; set; }

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
     
        public Bohater( string imie, int atak, int obrona) 
        {
            Imie = imie;
            Atak = atak;
            Obrona = obrona;
            Nieosobowy = false;
            Maksymalna_ilosc_ruchu = 1000;
            przywroc_caly_ruch_bohaterowi();
            Jednostki = new Jednostka[5];
        }

        public Bohater()
        {
            Imie = "";
            Atak = 0;
            Obrona = 0;
            Nieosobowy = true;
            Maksymalna_ilosc_ruchu = 1000;
            przywroc_caly_ruch_bohaterowi();
            Jednostki = new Jednostka[5];
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

        public void PrzywrocPortretyJednostkom()
        {
            foreach (Jednostka jednostka in Jednostki)
            {
                if (jednostka != null) { jednostka.PrzywrocPortret(); }
            }
        }

        public void przywroc_caly_ruch_bohaterowi()
        {
            Ilosc_ruchu = Maksymalna_ilosc_ruchu;
        }

        public void wykonaj_ruch(int ilosc)
        {
            Ilosc_ruchu -= ilosc;
        }

        public bool czy_ma_jednostki()
        {
            int i = 0;
            while (i < 5)
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

       

        public Jednostka DajJednostke(int numer_slotu)
        {
            return Jednostki[numer_slotu];
        }

        
        public void Rysuj(Graphics grafika)
        {
            Gracz wlasciciel = Wlasciciel;
            string kolor = "bez_koloru";
            if (wlasciciel != null)
            {
                kolor = wlasciciel.Kolor;
            }

            Image imgNew = Obrazy.GetBohater(kolor);
            grafika.DrawImage(imgNew, (PolozenieX * 40), (PolozenieY * 40), 40, 40);
        }

        public void Interakcja(Bohater bohater)
        {
            if(Wlasciciel!=bohater.Wlasciciel)
            {
                Bitwa bitwa = new Bitwa(bohater, this);
                bitwa.ShowDialog();

                //todo dorobic usuwanie bohatera
            }
        }

        public void AkcjaPoKliknieciu(Gra gra)
        {
            if (gra.AktualnyGracz(Wlasciciel))
            {
                gra.AktualnyBohater = this;
            }
        }
    }
}
