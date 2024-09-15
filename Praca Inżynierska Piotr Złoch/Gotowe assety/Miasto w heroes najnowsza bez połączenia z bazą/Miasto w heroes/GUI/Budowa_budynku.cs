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
    public partial class Budowa_budynku : Form
    {
        Miasto aktualne_miasto;
        Gracz aktualny_gracz;
        int nr_aktualnego_budynku;
        Gracz gracz;
        BazaJednostek bazaJednostek;
        public Budowa_budynku(Miasto miasto, int nr_budynku)
        {
            InitializeComponent();
            this.bazaJednostek = Gra.DajInstancje().BazaJednostek;
            gracz = miasto.Wlasciciel;
            aktualne_miasto = miasto;
            aktualny_gracz = gracz;
            nr_aktualnego_budynku = nr_budynku;
            strzalka_picturebox.Image = Properties.Resources.Strzałka;
            rysowanie_budynkow(przed_ulepszeniem_picturebox, po_budowie_picture_box);


        }

        private void rysowanie_budynkow(PictureBox przed, PictureBox po)
        {
            int budynek = aktualne_miasto.Sprawdzenie_budynku(nr_aktualnego_budynku);
            if (budynek == 0) { przed.Image = Properties.Resources.Strzałka; }
            else if (budynek == 1)
            {
                przed.Image = Properties.Resources.b0;
                po.Image = Properties.Resources.b1;
            }
            else if (budynek == 2) 
            { 
                przed.Image = Properties.Resources.b1;
                po.Image = Properties.Resources.b2;
            }
            else if (budynek == 3)
            { 
                przed.Image = Properties.Resources.b2;
                po.Image = Properties.Resources.b3;
            }
            else if (budynek == 4) 
            {
                przed.Image = Properties.Resources.b3;
                po.Image = Properties.Resources.b4;
            }
            else if (budynek == 5) 
            { 
                przed.Image = Properties.Resources.b4;
                po.Image = Properties.Resources.Strzałka;
            }
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Buduj_button_Click(object sender, EventArgs e)
        {
            int zloto = aktualny_gracz.Zloto;
            int cena = aktualne_miasto.Podaj_cene_budynku(nr_aktualnego_budynku);
            if (cena <= zloto)
            {
                aktualny_gracz.Zloto-=cena;
                aktualne_miasto.Budowa_budynku(nr_aktualnego_budynku, bazaJednostek);
                //Miasto_widok Miasto1 = new Miasto_widok(aktualne_miasto);
                //Miasto1.Show();
                Close();
            }

        }
    }
}
