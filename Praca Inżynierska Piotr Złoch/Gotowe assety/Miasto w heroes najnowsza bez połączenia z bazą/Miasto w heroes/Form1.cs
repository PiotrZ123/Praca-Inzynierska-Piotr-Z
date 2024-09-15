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

    public partial class Form1 : Form
    {
        Miasto[] miasto = new Miasto[4];
        Gracz[] gracz = new Gracz[4];
        Gracz aktualny_gracz;
        int aktualna_dzien = 1;
        int aktualna_tydzien = 1;
        int aktualna_miesiac = 1;

        public Form1()
        {
            InitializeComponent();

            miasto[0] = new Miasto(3,2);
            miasto[1] = new Miasto(1,34);
            miasto[2] = new Miasto(3,21);
            miasto[3] = new Miasto(4,23);

            gracz[0] = new Gracz("Gracz1","czerwony", 100000);
            gracz[1] = new Gracz("Gracz2", "zielony");
            gracz[2] = new Gracz("Gracz3", "niebieski");
            gracz[3] = new Gracz("Gracz4", "fioletowy");
            if (aktualny_gracz == null)
            {
                aktualny_gracz = gracz[0];
            }
            aktualny_gracz_label.Text = aktualny_gracz.Imie;
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";

        }

        private void Miasto_0_Click(object sender, EventArgs e)
        {
            if (aktualny_gracz.Imie == miasto[0].podaj_imie_aktualnego_wlasciciela())
            {
                Miasto_widok Miasto1 = new Miasto_widok(miasto[0], aktualny_gracz);
                Miasto1.Show();
            }
        }

        private void Miasto_1_Click(object sender, EventArgs e)
        {
            if (aktualny_gracz.Imie == miasto[1].podaj_imie_aktualnego_wlasciciela())
            {
                Miasto_widok Miasto1 = new Miasto_widok(miasto[1], aktualny_gracz);
                Miasto1.Show();
            }
        }

        private void Miasto_2_Click(object sender, EventArgs e)
        {
            Miasto_widok Miasto1 = new Miasto_widok(miasto[2], aktualny_gracz);
            Miasto1.Show();
        }

        private void Miasto_3_Click(object sender, EventArgs e)
        {
            Miasto_widok Miasto1 = new Miasto_widok(miasto[3], aktualny_gracz);
            Miasto1.Show();
        }

        private void zajmij_miasto_button_Click(object sender, EventArgs e)
        {
            miasto[0].zmiana_wlasciciela(aktualny_gracz);
        }

        private void zajmij2_button_Click(object sender, EventArgs e)
        {
            miasto[1].zmiana_wlasciciela(gracz[1]);
        }

        private void zakoncz_ture_Click(object sender, EventArgs e)
        {
            aktualna_dzien++;
            if (aktualna_dzien == 7)
            {
                aktualna_tydzien++;
                aktualna_dzien = 1;
                int q = 0;
                while (q <= 9)
                {
                    miasto[q].dodaj_przyrost_jednostki();
                    q++;
                }
            }
            if (aktualna_tydzien == 4)
            {
                aktualna_miesiac++;
                aktualna_tydzien = 1;
            }
            dzien_Label.Text = $"{aktualna_dzien}";
            tydzien_label.Text = $"{aktualna_tydzien}";
            Miesiac_label.Text = $"{aktualna_miesiac}";
            int i = 0;
            while (i <= 9)
            {
                miasto[i].czy_mozna_budowac_tak();
                miasto[i].daj_przychod_dla_wlasciciela();
                i++;
            }
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";
        }

        private void Gracz1_button_Click(object sender, EventArgs e)
        {
            aktualny_gracz = gracz[0];
            aktualny_gracz_label.Text = aktualny_gracz.Imie;
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";
        }

        private void Gracz2_button_Click(object sender, EventArgs e)
        {
            aktualny_gracz = gracz[1];
            aktualny_gracz_label.Text = aktualny_gracz.Imie;
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";
        }

        private void Gracz3_button_Click(object sender, EventArgs e)
        {
            aktualny_gracz = gracz[2];
            aktualny_gracz_label.Text = aktualny_gracz.Imie;
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";
        }

        private void Gracz4_button_Click(object sender, EventArgs e)
        {
            aktualny_gracz = gracz[3];
            aktualny_gracz_label.Text = aktualny_gracz.Imie;
            Ilosc_golda_label.Text = $"{aktualny_gracz.Gold}";
        }
    }
}
