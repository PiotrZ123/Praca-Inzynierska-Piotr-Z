using Animacje;
using Miasto_w_heroes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miasto_w_heroes.Kontrolki;
using System.Threading;
using Miasto_w_heroes.GUI;

namespace Miasto_w_heroes
{
    public partial class Bitwa : Form
    {
        Graphics g;
        Bohater lewy_atakujacy;
        Bohater prawy_broniocy;
        Jednostka aktualna_jednostka;
        int aktualna_jednostka_ilosc_ruchu = 5;
        Jednostka[,] jednostki = new Jednostka[2, 5];
        Jednostka[] jednostki_lista = new Jednostka[10];
        object[,] miejsce_na_mapie = new object[9, 20];


        int ii = 0; // zmienne do wyboru jednostek nie tykac
        int jj = 0; // zmienne do wyboru jednostek nie tykac


        public Bitwa(Bohater atakujocy,Bohater broniocy)
        {
            lewy_atakujacy = atakujocy;
            prawy_broniocy = broniocy;
            if (lewy_atakujacy == null) { Close(); }
            else if (prawy_broniocy == null) { Close(); }
            przypisywanie_jednostek();
            InitializeComponent();
            LewybohaterWidok.UstawBohatera(lewy_atakujacy);
            PrawybohaterWidok.UstawBohatera(prawy_broniocy);
            lewy_atakujacy.PrzywrocPortretyJednostkom();
            prawy_broniocy.PrzywrocPortretyJednostkom();
            ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
            ruch_jednostek();

        }




        public int ruch_jednostek()
        {
            if (lewy_atakujacy != null && prawy_broniocy != null)
            {
                while (ii < 5)
                {
                    if (jj == 0)
                    {
                        if (jednostki[0, ii] != null)
                        {
                            aktualna_jednostka = jednostki[0, ii];
                            aktualna_jednostka_ilosc_ruchu = aktualna_jednostka.Szybkosc;
                            ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
                            jj = 1;
                            return 0;
                        }
                        jj = 1;
                    }
                    else if (jj == 1)
                    {
                        if (jednostki[1, ii] != null)
                        {
                            aktualna_jednostka = jednostki[1, ii];
                            aktualna_jednostka_ilosc_ruchu = aktualna_jednostka.Szybkosc;
                            ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
                            jj = 0;
                            ii++;
                            return 0;
                        }
                        ii++;
                        jj = 0;
                        if (ii == 5)
                        {
                            ii = 0;
                            jj = 0;
                        }
                    }
                }
            }
            return 0;
        }


        public void przypisywanie_jednostek()
        {
            if (lewy_atakujacy != null && prawy_broniocy != null)
            {
                int i = 0;
                while (i < 5)
                {
                    jednostki[0, i] = lewy_atakujacy.DajJednostke(i);
                    if (jednostki[0, i] != null)
                    {
                        miejsce_na_mapie[i * 2, 0] = jednostki[0, i];
                        jednostki[0, i].ustaw_lokalizacje_jednostki(i * 2, 0);
                    }
                    jednostki[1, i] = prawy_broniocy.DajJednostke(i);
                    if (jednostki[1,i] != null)
                    {
                        miejsce_na_mapie[i * 2, 19] = jednostki[1, i];
                        jednostki[1, i].ustaw_lokalizacje_jednostki(i * 2, 19);
                    }
                    i++;
                }
            }
        }

        public void ktora_jednostka_aktualnie_sie_rusza(int numer, int lewy_prawy_bohater)
        {
            if (jednostki[lewy_prawy_bohater, numer] != null)
            {
                aktualna_jednostka = jednostki[lewy_prawy_bohater, numer];
            }
        }

        public void WykonajAnimacjeAtakuJednostki(Jednostka jednostka)
        {
            Animacja animacja = new Animacja(jednostka.Numer,0);
            animacja.RysujRaz(this.CreateGraphics(),jednostka.Y + 2, jednostka.X );
            //animacja.RysujCiagleAsync(this.CreateGraphics(), 2, 2);
        }

        public void WykonajAnimacjeSmierciJednostki(Jednostka jednostka)
        {
            Animacja animacja = new Animacja(jednostka.Numer, 1);
            animacja.RysujRaz(this.CreateGraphics(), jednostka.Y + 2, jednostka.X);
            //animacja.RysujCiagleAsync(this.CreateGraphics(), 2, 2);
        }

        private void Bitwa_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            g = e.Graphics;
            int i = 0;
            while (i < 1000)
            {
                g.DrawLine(p, 50 * i, 40000, 50 * i, 0);
                g.DrawLine(p, 40000, 50 * i, 0, 50 * i);
                i++;
            }
            foreach (Jednostka jednostka in jednostki)
            {
                if (jednostka != null)
                {
                    jednostka.RysujBitwa(g);
                }
            }
        }

        public void jednostka_wykonala_ruch()
        {
            aktualna_jednostka_ilosc_ruchu--;
            ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
            if (aktualna_jednostka_ilosc_ruchu <= 0)
            {
                ruch_jednostek();
            }

        }

        public Bohater ZwrocBohateraPoWlascicielu(Gracz wlasciciel)
        {
            if (lewy_atakujacy.Wlasciciel == wlasciciel) { return lewy_atakujacy; }
            else{ return prawy_broniocy; }
        }

        public void kontakt_miedzy_jednostkami(int x_drugiej_jednostki, int y_drugiej_jednostki)
        {
            {
                Jednostka jednostka = miejsce_na_mapie[x_drugiej_jednostki, y_drugiej_jednostki] as Jednostka;
                if (aktualna_jednostka.Wlasciciel != jednostka.Wlasciciel)
                {
                    aktualna_jednostka_ilosc_ruchu = 0;
                    ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
                    Bohater BohaterAtakujacy = ZwrocBohateraPoWlascicielu(aktualna_jednostka.Wlasciciel);
                    Bohater BohaterBroniacy = ZwrocBohateraPoWlascicielu(jednostka.Wlasciciel);
                    aktualna_jednostka.atak_jednostki(jednostka, BohaterAtakujacy.Atak, BohaterBroniacy.Obrona);
                    WykonajAnimacjeAtakuJednostki(aktualna_jednostka);
                    if (jednostka.Ilosc <= 0)
                    {
                        miejsce_na_mapie[x_drugiej_jednostki, y_drugiej_jednostki] = null;
                        for (int i = 0; i < jednostki.GetLength(0); i++)
                        {
                            for (int j = 0; j < jednostki.GetLength(1); j++)
                            {
                                if (jednostki[i, j] == jednostka)
                                {
                                    WykonajAnimacjeSmierciJednostki(jednostki[i, j]);
                                    jednostki[i, j] = null;
                                    if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                                    else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                                    break;
                                }
                            }
                        }
                    }
                    Refresh();
                    ruch_jednostek();

                }
            }
        }


        public void ZawartoscJednostkaIdzieNa(int x_aktualnej, int y_aktualnej, int x_nastepny,int y_nastepny)
        {
            if (x_nastepny >= 0 && x_nastepny <= 8 && y_nastepny >= 0 && y_nastepny <= 19)
            {
                if (miejsce_na_mapie[x_nastepny, y_nastepny] == null)
                {
                    aktualna_jednostka.ustaw_lokalizacje_jednostki(x_nastepny, y_nastepny);
                    miejsce_na_mapie[x_aktualnej, y_aktualnej] = null;
                    miejsce_na_mapie[x_nastepny, y_nastepny] = aktualna_jednostka;
                    jednostka_wykonala_ruch();
                    Refresh();
                }
                else
                {
                    kontakt_miedzy_jednostkami(x_nastepny, y_nastepny);
                }

            }
        }

        private void gora_button_Click(object sender, EventArgs e)
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x,y,x-1,y);
        }

        private void lewy_button_Click(object sender, EventArgs e)
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x, y-1);
        }

        private void dol_button_Click(object sender, EventArgs e)
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x + 1, y);
        }

        private void prawo_button_Click(object sender, EventArgs e)
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x, y+1);
        }

        private void zakoncz_ture_button_Click(object sender, EventArgs e)
        {
            aktualna_jednostka_ilosc_ruchu = 0;
            ilosc_ruchu_label.Text = $"ilosc ruchu:{aktualna_jednostka_ilosc_ruchu}";
            ruch_jednostek();
        }

        private void zakoncz_bitwe_button_Click(object sender, EventArgs e)
        {
            if (lewy_atakujacy.czy_ma_jednostki() == false|| prawy_broniocy.czy_ma_jednostki() == false)
            {
                Close();
            }
        }

        private void Bitwa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Uzyskaj pozycję kursora myszy
                Point mousePosition = e.Location;

                for (int i = 0; i < jednostki.GetLength(0); i++)
                {
                    for (int j = 0; j < jednostki.GetLength(1); j++)
                    {
                        if (jednostki[i, j] != null && jednostki[i, j].X * 50 <= mousePosition.Y && jednostki[i, j].X * 50 + 50 >= mousePosition.Y &&
                             jednostki[i, j].Y * 50 + 100 <= mousePosition.X && jednostki[i, j].Y * 50 + 100 + 50 >= mousePosition.X)
                        {
                            bool CzyMoznaZwolnic;
                            if (jednostki[i, j].Wlasciciel == aktualna_jednostka.Wlasciciel) { CzyMoznaZwolnic = true; }
                            else { CzyMoznaZwolnic = false; }
                            JednostkaWidok rekrutacja = new JednostkaWidok(jednostki[i, j], false, false, CzyMoznaZwolnic);
                            rekrutacja.ShowDialog(this);
                            int result = rekrutacja.Result;
                            if (result == 1)
                            {
                                WykonajAnimacjeSmierciJednostki(jednostki[i, j]);
                                jednostki[i, j] = null;
                                if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                                else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                                Refresh();
                                break;
                            }
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = e.Location;
                for (int i = 0; i < jednostki.GetLength(0); i++)
                {
                    for (int j = 0; j < jednostki.GetLength(1); j++)
                    {
                        if (jednostki[i, j] != null && jednostki[i, j].X * 50 <= mousePosition.Y && jednostki[i, j].X * 50 + 50 >= mousePosition.Y &&
                             jednostki[i, j].Y * 50 + 100 <= mousePosition.X && jednostki[i, j].Y * 50 + 100 + 50 >= mousePosition.X)
                        {
                            if (aktualna_jednostka.Strzela == true && aktualna_jednostka.Ilosc_strzal > 0 && aktualna_jednostka.Wlasciciel != jednostki[i, j].Wlasciciel)
                            {
                                WykonajAnimacjeAtakuJednostki(aktualna_jednostka);
                                Bohater BohaterAtakujacy = ZwrocBohateraPoWlascicielu(aktualna_jednostka.Wlasciciel);
                                Bohater BohaterBroniacy = ZwrocBohateraPoWlascicielu(jednostki[i, j].Wlasciciel);
                                aktualna_jednostka.atak_jednostki(jednostki[i, j], BohaterAtakujacy.Atak, BohaterBroniacy.Obrona);
                                if (jednostki[i, j].Ilosc <= 0)
                                {
                                    WykonajAnimacjeSmierciJednostki(jednostki[i, j]);
                                    jednostki[i, j] = null;
                                    if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                                    else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                                    Refresh();
                                }
                                ruch_jednostek();
                                break;
                            }

                        }
                    }
                }
            }
        }
    }
}
