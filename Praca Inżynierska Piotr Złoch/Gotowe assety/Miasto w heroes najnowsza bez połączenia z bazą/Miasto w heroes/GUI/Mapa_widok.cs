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
using Kontrolki_by_wwsi;
using Miasto_w_heroes.Services;
using ZnajdowanieDrogi;

namespace Miasto_w_heroes
{
    public partial class Mapa_widok : Form
    {
        private Gra gra;
        
        protected bool przeszkoda = true;
       
        protected Graphics g;
        protected Jednostka jednostka_tymczasowa;
        protected Bohater bohater_tymczasowy;
        int x = 0, y = 0;
        private bool inicjalizacja;
        Point koniec;//zaznaczony punkt końcowy

        public Mapa_widok()
        {
            InitializeComponent();
            
            //tworz_liste_bohaterow();
            //tworz_liste_miast();
        }

        public Mapa_widok(Gra gra)
        {
            InitializeComponent();
            
            this.gra = gra;
            inicjalizacja = true;
            Bohaterowie_lista_listbox.DataSource = gra.BohaterowieGracza;
            Miasta_lista_listbox.DataSource = gra.MiastaGracza;
            inicjalizacja = false;
        }

        public void UsunBohater(Bohater bohater)
        {
            gra.Mapa.UsunBohatera(bohater);
        }

        private void ZmianaBohatera(Bohater bohater)
        {
            gra.AktualnyBohater = bohater;
            aktualny_bohater_label.Text = $"aktulany bohater : {bohater.Imie}";
            Ilosc_ruchu_label.Text = $"ilość ruchu : {bohater.Ilosc_ruchu}";
            Pasek_ruchu_bohatera.Max_wartosc = bohater.Maksymalna_ilosc_ruchu;
            Pasek_ruchu_bohatera.Obecna_wartosc = bohater.Ilosc_ruchu;
        }

        private void Bohaterowie_lista_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inicjalizacja)
            {
                return;
            }

            if (Bohaterowie_lista_listbox.SelectedItem != null)
            {
                ZmianaBohatera((Bohater)Bohaterowie_lista_listbox.SelectedItem);
            }
        }

        private void Mapa_widok_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);
            g = e.Graphics;
            int i = 0;
            g.TranslateTransform(x, y);
            while (i < 1000)
            {
                g.DrawLine(p, 40 * i, 40000, 40 * i, 0);
                g.DrawLine(p, 40000, 40 * i, 0, 40 * i);
                i++;
            }
            
            ObiektNaMapie[,] przeszkody = gra.Mapa.Przeszkody;

            for (int y1 = 0; y1 < przeszkody.GetLength(1); y1++)
            {
                for (int x1 = 0; x1 < przeszkody.GetLength(0); x1++)
                {
                    if(przeszkody[x1, y1]!=null)
                    {
                        przeszkody[x1, y1].Rysuj(g);
                    }
                }
            }
        }

        private void zakoncz_ture_button_Click(object sender, EventArgs e)
        {
            gra.ZmienTure();
            dzien_Label.Text = $"Dzień: {gra.Dzien}";
            tydzien_label.Text = $"Tydzień {gra.Tydzien}";
            Miesiac_label.Text = $"Miesiąc: {gra.Miesiac}";
            Ilosc_golda_label.Text = $"{gra.ZlotoGracza}";

            aktualny_gracz_label.Text = gra.ImieGracza;
            numer_gracza_label.Text = $"{gra.IndexGracza}";

            Bohaterowie_lista_listbox.DataSource = gra.BohaterowieGracza;
            Miasta_lista_listbox.DataSource = gra.MiastaGracza;
        }

        private void Miasta_lista_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicjalizacja)
            {
                return;
            }
            if (Miasta_lista_listbox.SelectedItem != null)
            {
                Miasto miasto = Miasta_lista_listbox.SelectedItem as Miasto;
               // miasto.Wloz_bohatera_poza_miastem(null);
                Miasto_widok miastoWidok = new Miasto_widok(miasto);
                miastoWidok.Inicjalizuj(null);
                miastoWidok.ShowDialog(this);

            }
        }

        private void ruch_do_buttonow(int x, int y)
        {
            gra.Ruch(x, y);
            if (gra.AktualnyBohater!=null)
            {
                Pasek_ruchu_bohatera.Obecna_wartosc = gra.AktualnyBohater.Ilosc_ruchu;
                Ilosc_ruchu_label.Text = $"ilość ruchu : {gra.AktualnyBohater.Ilosc_ruchu}";
            }
            Refresh();
        }

        private void gora_button_Click(object sender, EventArgs e)
        {
            ruch_do_buttonow(0, - 1);
        }

        private void lewy_button_Click(object sender, EventArgs e)
        {
            ruch_do_buttonow(- 1, 0);
        }

        private void dol_button_Click(object sender, EventArgs e)
        {
            ruch_do_buttonow(0, 1);
        }

        private void prawo_button_Click(object sender, EventArgs e)
        {
            ruch_do_buttonow(1, 0);
        }

        private void ekran_gora_button_Click(object sender, EventArgs e)
        {
            if (y<0)
            {
                y = y + 40;
                Refresh(); ;
            }
        }
        private void ekran_lewo_button_Click(object sender, EventArgs e)
        {
            if (x<0)
            {
                x = x + 40;
                Refresh();
            }
        }

        private void ekran_dol_button_Click(object sender, EventArgs e)
        {
            if (y > -40000)
            {
                y = y - 40;
                Refresh();
            }
        }

        private void ekran_prawo_button_Click(object sender, EventArgs e)
        {
            if (x > -40000)
            {
                x = x - 40;
                Refresh();
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            Gra.DajInstancje().Zapisz();
        }

        private void RysujDroge(Graphics grafika, int x, int y)
        {
            Image image = Image.FromFile(@"..\..\grafika\Strzalka.png");
            grafika.DrawImage(image, x * 40, y * 40, 40, 40);
        }

        private void Mapa_widok_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Drawing.Point location = e.Location;
                int indexX =  (location.X - x) / 40;
                int indexY = (location.Y - y) / 40;

                if (gra.Mapa.Przeszkody[indexX, indexY] != null)
                {
                    gra.Mapa.Przeszkody[indexX, indexY].AkcjaPoKliknieciu(gra);
                }
                if(gra.AktualnyBohater!= Bohaterowie_lista_listbox.SelectedItem)
                {
                    Bohaterowie_lista_listbox.SelectedItem = gra.AktualnyBohater;
                }
                if (gra.Mapa.Przeszkody[indexX, indexY] == null && gra.AktualnyBohater != null)
                {
                    Refresh();
                    int x = gra.AktualnyBohater.PolozenieX;
                    int y = gra.AktualnyBohater.PolozenieY;
                    bool[,] map = new bool[1000,1000];
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            // Pobierz obiekt z mapy
                            object obj = gra.Mapa.Przeszkody[i, j];

                            if(obj != null)map[i, j] = true;
                        }
                    }
                    Point bohater = new Point(gra.AktualnyBohater.PolozenieX, gra.AktualnyBohater.PolozenieY);
                    Point koniec = new Point(indexX, indexY);
                    //ZnajdowanieSciezki znajdz = new ZnajdowanieSciezki(this.CreateGraphics(),map);
                    //znajdz.FindPath(bohater, koniec);
                    ZnajdywanieDrogi znajdz = new ZnajdywanieDrogi(bohater,koniec, map,1000,1000,this.CreateGraphics());
                    List<Point> punkty = znajdz.ZnajdzNajkrotszaDroga();
                    if (this.koniec == koniec)
                    {
                        Point poprzedni = new Point(bohater.X, bohater.Y);
                        foreach (Point item in punkty)
                        {
                            int x1 = item.X - poprzedni.X;
                            int y1 = item.Y - poprzedni.Y;
                            poprzedni = item;
                            ruch_do_buttonow(x1, y1);
                            //ruch_do_buttonow(0,0);
                        }
                    }
                    this.koniec = koniec;

                }
            }
        }
    }
}
