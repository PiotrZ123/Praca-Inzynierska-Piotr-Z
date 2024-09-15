using Praca_Inżynierska_Piotr_Złoch.Logika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_Inżynierska_Piotr_Złoch.GUI
{
    public partial class Opcje : Form
    {
        public Opcje()
        {
            InitializeComponent();
            try
            {
                AktualnaSzybkoscLabel.Text = $"x{Config.Odczytaj("Szybkosc")}";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SzybkoscRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Config.Zapisz(0.25, "Szybkosc");
            AktualnaSzybkoscLabel.Text = "x0,25";
        }

        private void SzybkoscRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Config.Zapisz(0.5, "Szybkosc");
            AktualnaSzybkoscLabel.Text = "x0,5";
        }

        private void SzybkoscRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Config.Zapisz(1, "Szybkosc");
            AktualnaSzybkoscLabel.Text = "x1";
        }

        private void SzybkoscRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Config.Zapisz(2, "Szybkosc");
            AktualnaSzybkoscLabel.Text = "x2";
        }

        private void SzybkoscRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Config.Zapisz(4, "Szybkosc");
            AktualnaSzybkoscLabel.Text = "x4";
        }
    }
}
