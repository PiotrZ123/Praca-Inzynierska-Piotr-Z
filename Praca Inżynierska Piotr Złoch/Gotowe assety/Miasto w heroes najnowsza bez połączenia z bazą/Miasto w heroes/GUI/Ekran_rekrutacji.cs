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

namespace Miasto_w_heroes
{
    public partial class Ekran_rekrutacji : Form
    {
        Jednostka aktualna_jednostka;
        int koszt_danej_jednostki;
        int max_rekrutacji_jednostki;
        Miasto aktualne_miasto;
        Gracz gracz;
        Jednostka[] jednostka = new Jednostka[10];
        public Ekran_rekrutacji(Miasto miasto)
        {
            InitializeComponent();
            aktualne_miasto = miasto;
            this.gracz = miasto.Wlasciciel;
            int i = 0;
            while (i <= 4)
            {
                jednostka[i] = aktualne_miasto.Oddaj_jednostke_do_rekrutacji_po_numerze_budynku(i);
                i++;
            }
            rysowanie_jednostek(Jednostka_1_button, 0);
            rysowanie_jednostek(Jednostka_2_button, 1);
            rysowanie_jednostek(Jednostka_3_button, 2);
            rysowanie_jednostek(Jednostka_4_button, 3);
            rysowanie_jednostek(Jednostka_5_button, 4);
        }

        private void zamknij_button_Click(object sender, EventArgs e)
        {
            if (aktualne_miasto != null & gracz != null)
            {
                Close();
            }
            else Close();
        }

        private void rysowanie_jednostek(Button przed, int nr_aktualnego_budynku)
        {
            int budynek = aktualne_miasto.Sprawdzenie_budynku(nr_aktualnego_budynku);
            if (budynek == 0) { }
            else if (budynek == 1) { }
            else if (budynek >= 2 && budynek <= 5)
            {
                przed.Image = jednostka[nr_aktualnego_budynku].Portret;
            }
        }

        private void Rekrutacja_button_Click(object sender, EventArgs e)
        {
            int liczba = int.Parse(ilosc_textBox.Text);
            int gold = gracz.Zloto;
            if (liczba > 0 && gold >= liczba * koszt_danej_jednostki
                && aktualne_miasto.UstawJednosteDoMiasta(aktualna_jednostka, liczba))
            {
                gracz.Zloto -= liczba * koszt_danej_jednostki;
                ilosc_textBox.Text = $"{0}";
                koszt_label.Text = $"Koszt: {0}";
                int bufor = max_rekrutacji_jednostki - liczba;
                max_rekrutacji_jednostki = max_rekrutacji_jednostki - liczba;
                aktualna_jednostka.Przyrost = bufor;
                aktualna_jednostka.Ilosc = liczba;
            }
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            int liczba;
            liczba = int.Parse(ilosc_textBox.Text);
            if (liczba < max_rekrutacji_jednostki)
            {
                liczba++;
                string liczba1 = $"{liczba}";
                ilosc_textBox.Text = liczba1;
                koszt_label.Text = $"Koszt: {liczba * koszt_danej_jednostki}";
            }
        }

        private void odejmij_button_Click(object sender, EventArgs e)
        {
            int liczba;
            liczba = int.Parse(ilosc_textBox.Text);
            if (liczba > 0)
            {
                liczba--;
                string liczba1 = $"{liczba}";
                ilosc_textBox.Text = liczba1;
                koszt_label.Text = $"Koszt: {liczba * koszt_danej_jednostki}";
            }
        }

        private void min_jednostek_button_Click(object sender, EventArgs e)
        {
            ilosc_textBox.Text = $"{0}";
            koszt_label.Text = $"Koszt: {0}";
        }

        private void amks_jednostek_button_Click(object sender, EventArgs e)
        {
            ilosc_textBox.Text = $"{max_rekrutacji_jednostki}";
            koszt_label.Text = $"Koszt: {max_rekrutacji_jednostki * koszt_danej_jednostki}";
        }

        private void JednostkaClickZawartosc(Button button,int numer)
        {
            if (button.Image != null && jednostka[numer] != null)
            {
                rekrutacja_panel.Enabled = true;
                ilosc_textBox.Text = $"{0}";
                koszt_label.Text = $"Koszt: {0}";
                rekrutacja_picturebox.Image = button.Image;
                aktualna_jednostka = aktualne_miasto.Oddaj_jednostke_do_rekrutacji_po_numerze_budynku(numer);
                max_rekrutacji_jednostki = aktualna_jednostka.Przyrost;
                koszt_danej_jednostki = aktualna_jednostka.Koszt;
            }
        }

        private void Jednostka_1_Click(object sender, EventArgs e)
        {
            JednostkaClickZawartosc(Jednostka_1_button, 0);
        }

        private void Jednostka_2_button_Click(object sender, EventArgs e)
        {
            JednostkaClickZawartosc(Jednostka_2_button, 1);
        }

        private void Jednostka_3_button_Click(object sender, EventArgs e)
        {
            JednostkaClickZawartosc(Jednostka_3_button, 2);
        }

        private void Jednostka_4_button_Click(object sender, EventArgs e)
        {
            JednostkaClickZawartosc(Jednostka_4_button, 3);
        }

        private void Jednostka_5_button_Click(object sender, EventArgs e)
        {
            JednostkaClickZawartosc(Jednostka_5_button, 4);
        }
    }
}
