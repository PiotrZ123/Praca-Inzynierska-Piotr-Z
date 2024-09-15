using Miasto_w_heroes.GUI;
using Miasto_w_heroes.Services;
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
    public partial class Ekran_startowy : Form
    {
        public Ekran_startowy()
        {
            InitializeComponent();
        }

        private void wejscie_do_formularza_testowego_Click(object sender, EventArgs e)
        {
            
            //Form1 testowy = new Form1();
            //testowy.Show();
        }

        private void Graj_button_Click(object sender, EventArgs e)
        {
            wybor_map testowy = new wybor_map();
            testowy.Show();
        }

        private void Zamknij_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Wczytaj_button_Click(object sender, EventArgs e)
        {
            EkranOdczytu ekranOdczytu = new EkranOdczytu(Gra.DajInstancje().WczytajListeZapisow());
            ekranOdczytu.ShowDialog(this);
            if (ekranOdczytu.Poprawne)
            {
                Gra.DajInstancje().Wczytaj(ekranOdczytu.Id);
                Mapa_widok testowy = new Mapa_widok(Gra.DajInstancje());
                testowy.ShowDialog(this);

            }


            // Gra.DajInstancje().Usun(3);
        }

        private void Opcje_button_Click(object sender, EventArgs e)
        {
            Opcje opcje = new Opcje();
            opcje.ShowDialog();
        }
    }
}
