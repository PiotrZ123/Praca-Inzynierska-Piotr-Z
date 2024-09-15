using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Praca_Inżynierska_Piotr_Złoch.Logika;
using Miasto_w_heroes.GUI;

namespace Praca_Inżynierska_Piotr_Złoch.GUI
{
    public partial class Bitwa : Form, RysowanieAnimacji
    {
        int numerPoziomu;
        Bohater lewy_atakujacy;
        Bohater prawy_broniocy;
        PoleBitwy Mapa;
        Point punkt;

        public Bitwa(Bohater atakujocy,Bohater broniocy, int numer)
        {
            numerPoziomu = numer;
            lewy_atakujacy = atakujocy;
            prawy_broniocy = broniocy;
            if (lewy_atakujacy == null) { Close(); }
            else if (prawy_broniocy == null) { Close(); }
            Mapa = new PoleBitwy(atakujocy, broniocy,this,numerPoziomu);
            InitializeComponent();
            AktualizujPola();

        }

        public void WykonajAnimacjeAtakuJednostki(Jednostka jednostka)
        {
            Animacja animacja = new Animacja(jednostka.Numer, 0);
            animacja.RysujRaz(this.CreateGraphics(), jednostka.Y + 2, jednostka.X);
        }

        public void WykonajAnimacjeSmierciJednostki(Jednostka jednostka)
        {
            Animacja animacja = new Animacja(jednostka.Numer, 1);
            animacja.RysujRaz(this.CreateGraphics(), jednostka.Y + 2, jednostka.X);
        }


        private void AktualizujPola()
        {
            LewybohaterWidok.UstawBohatera(lewy_atakujacy);
            PrawybohaterWidok.UstawBohatera(prawy_broniocy);
            ilosc_ruchu_label.Text = $"ilosc ruchu:{Mapa.ZwrocIloscRuchu()}";
            Refresh();
            kolejkaJednostek1.Odswierz(lewy_atakujacy, prawy_broniocy,Mapa.ZwrocAktualnaJednostka());
        }

        private void Bitwa_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            Graphics g = e.Graphics;
            int i = 0;
            while (i < 1000)
            {
                g.DrawLine(p, 50 * i, 40000, 50 * i, 0);
                g.DrawLine(p, 40000, 50 * i, 0, 50 * i);
                i++;
            }
            Jednostka[,] jednostki = Mapa.ZwrocListeJednostek(); 
            foreach (Jednostka jednostka in jednostki)
            {
                if (jednostka != null)
                {
                    e.Graphics.DrawImage(jednostka.Portret, jednostka.Y * 50 + 100, 50 * jednostka.X, 50, 50);
                }
            }
            kolejkaJednostek1.Odswierz(lewy_atakujacy, prawy_broniocy,Mapa.ZwrocAktualnaJednostka());
            ZaznaczAktualnaJednostka(g);
        }

        private void ZaznaczAktualnaJednostka(Graphics g)
        {
            Jednostka  jednostka = Mapa.ZwrocAktualnaJednostka();
            using (Pen pen = new Pen(Color.Red, 4))
            {
                g.DrawRectangle(pen, ((jednostka.Y + 1) * 50)+50, jednostka.X*50, 50, 50);
            }
        }

        private void gora_button_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieGora();
            AktualizujPola();
        }

        private void lewy_button_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieLewo();
            AktualizujPola();
        }

        private void dol_button_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieDol();
            AktualizujPola();
        }

        private void prawo_button_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdziePrawo();
            AktualizujPola();
        }

        private void PrawoGoraButtno_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieGoraPrawo();
            AktualizujPola();
        }

        private void LewoGoraButton_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieGoraLewo();
            AktualizujPola();
        }

        private void LewyDolButton_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdzieDolLewo();
            AktualizujPola();
        }

        private void PrawyDolButton_Click(object sender, EventArgs e)
        {
            Mapa.JednostkaIdziedolPrawo();
            AktualizujPola();
        }

        private void zakoncz_ture_button_Click(object sender, EventArgs e)
        {
            Mapa.ruch_jednostek();
            AktualizujPola();
        }

        private void zakoncz_bitwe_button_Click(object sender, EventArgs e)
        {
            Mapa.ZakonczBitwe();
        }

        private void RysujDroge(int x, int y)
        {
            Image image = Obrazy.GetStrzalka();
            this.CreateGraphics().DrawImage(image, x * 50 + 100, y * 50, 50, 50);
        }
        private void RysujDrogeBezRuchu(int x, int y)
        {
            Image image = Obrazy.GetTarcza();
            this.CreateGraphics().DrawImage(image, x * 50 + 100, y * 50, 50, 50);
        }

        private void Bitwa_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;
            if (e.Button == MouseButtons.Right)// Widok jednostki
            {
                for (int i = 0; i < Mapa.ZwrocListeJednostek().GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa.ZwrocListeJednostek().GetLength(1); j++)
                    {
                        if (Mapa.ZwrocListeJednostek()[i, j] != null && Mapa.ZwrocListeJednostek()[i, j].X * 50 <= mousePosition.Y && Mapa.ZwrocListeJednostek()[i, j].X * 50 + 50 >= mousePosition.Y &&
                             Mapa.ZwrocListeJednostek()[i, j].Y * 50 + 100 <= mousePosition.X && Mapa.ZwrocListeJednostek()[i, j].Y * 50 + 100 + 50 >= mousePosition.X)
                        {
                            bool CzyMoznaZwolnic;
                            if (Mapa.ZwrocListeJednostek()[i, j].Wlasciciel == Mapa.ZwrocAktualnaJednostka().Wlasciciel) { CzyMoznaZwolnic = true; }
                            else { CzyMoznaZwolnic = false; }
                            JednostkaWidok rekrutacja = new JednostkaWidok(Mapa.ZwrocListeJednostek()[i, j], CzyMoznaZwolnic);
                            rekrutacja.ShowDialog(this);
                            int result = rekrutacja.Result;
                            if (result == 1)
                            {
                                WykonajAnimacjeSmierciJednostki(Mapa.ZwrocListeJednostek()[i, j]);
                                Mapa.ZwrocListeJednostek()[i, j] = null;
                                if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                                else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                                Refresh();
                                break;
                            }
                        }
                    }
                }
            }

            if (e.Button == MouseButtons.Left)//Wybierz drogę
            {
                System.Drawing.Point location = e.Location;
                int indexX = (location.X) / 50 - 2;
                int indexY = (location.Y) / 50;

                if (Mapa.miejsce_na_mapie[indexY, indexX] == null)
                {
                    Refresh();
                    int x = Mapa.ZwrocAktualnaJednostka().X;
                    int y = Mapa.ZwrocAktualnaJednostka().Y;
                    Point poczatek = new Point(x, y);
                    Point koniec = new Point(indexX, indexY);
                    List<Point> droga = ZnajdywanieDrogi.ZwrocNajkrotszaDroga(Mapa.miejsce_na_mapie, x, y, indexY, indexX);
                    int IloscRuchu = Mapa.ZwrocIloscRuchu();
                    if (droga != null)
                    {
                        foreach (var item in droga)
                        {
                            if (item != poczatek)
                            {
                                if (IloscRuchu > 0)
                                {
                                    RysujDroge(item.Y, item.X);
                                    IloscRuchu--;
                                }
                                else RysujDrogeBezRuchu(item.Y, item.X);
                            }
                        }
                    }
                    if (punkt == koniec)
                    {
                        Mapa.WykonajRuchLista(droga);
                        AktualizujPola();
                    }
                    punkt = koniec;


                }
            }
            if (e.Button == MouseButtons.Left)//atak dystansowy
            {
                for (int i = 0; i < Mapa.ZwrocListeJednostek().GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa.ZwrocListeJednostek().GetLength(1); j++)
                    {
                        if (Mapa.ZwrocListeJednostek()[i, j] != null && Mapa.ZwrocListeJednostek()[i, j].X * 50 <= mousePosition.Y && Mapa.ZwrocListeJednostek()[i, j].X * 50 + 50 >= mousePosition.Y &&
                             Mapa.ZwrocListeJednostek()[i, j].Y * 50 + 100 <= mousePosition.X && Mapa.ZwrocListeJednostek()[i, j].Y * 50 + 100 + 50 >= mousePosition.X)
                        {
                            if (Mapa.ZwrocAktualnaJednostka().Strzela == true && Mapa.ZwrocAktualnaJednostka().Ilosc_strzal > 0 && Mapa.ZwrocAktualnaJednostka().Wlasciciel != Mapa.ZwrocListeJednostek()[i, j].Wlasciciel)
                            {
                                WykonajAnimacjeAtakuJednostki(Mapa.ZwrocAktualnaJednostka());
                                Bohater BohaterAtakujacy = Mapa.ZwrocBohateraPoWlascicielu(Mapa.ZwrocAktualnaJednostka().Wlasciciel);
                                Bohater BohaterBroniacy = Mapa.ZwrocBohateraPoWlascicielu(Mapa.ZwrocListeJednostek()[i, j].Wlasciciel);
                                Mapa.ZwrocAktualnaJednostka().atak_jednostki(Mapa.ZwrocListeJednostek()[i, j], BohaterAtakujacy.Atak, BohaterBroniacy.Obrona);
                                if (Mapa.ZwrocListeJednostek()[i, j].Ilosc <= 0)
                                {
                                    WykonajAnimacjeSmierciJednostki(Mapa.ZwrocListeJednostek()[i, j]);
                                    Mapa.ZwrocListeJednostek()[i, j] = null;
                                    if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                                    else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                                    Refresh();
                                }
                                Mapa.ruch_jednostek();
                                break;
                            }

                        }
                    }
                }
            }
            
        }

        private void UmiejetnoscButton_Click(object sender, EventArgs e)
        {
            if (Mapa.CzyMozeUmiejetnoscLewy == true && Mapa.ZwrocAktualnaJednostka().Wlasciciel == lewy_atakujacy.Wlasciciel)
            {
                KsiegaUmiejetnosci opcje = new KsiegaUmiejetnosci(Mapa.ZwrocListeJednostek(), Mapa.ZwrocAktualnaJednostka().Wlasciciel);
                opcje.ShowDialog();
                if (opcje.Zwroc() == true) Mapa.CzyMozeUmiejetnoscLewy = false;
            }
        }

        private void UmiejetnoscPrawyButton_Click(object sender, EventArgs e)
        {
            if (Mapa.CzyMozeUmiejetnoscPrawy == true && Mapa.ZwrocAktualnaJednostka().Wlasciciel == prawy_broniocy.Wlasciciel)
            {
                KsiegaUmiejetnosci opcje = new KsiegaUmiejetnosci(Mapa.ZwrocListeJednostek(), Mapa.ZwrocAktualnaJednostka().Wlasciciel);
                opcje.ShowDialog();
                if (opcje.Zwroc() == true) Mapa.CzyMozeUmiejetnoscPrawy = false;
            }
        }
    }
}
