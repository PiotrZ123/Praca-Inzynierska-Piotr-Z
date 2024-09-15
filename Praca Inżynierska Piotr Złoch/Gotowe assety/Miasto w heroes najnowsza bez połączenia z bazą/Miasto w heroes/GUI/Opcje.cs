using ConfigRozwiazanie;
using Miasto_w_heroes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miasto_w_heroes.GUI
{
    public partial class Opcje : Form
    {
        double szybkosc = 1;
        public Opcje()
        {
            InitializeComponent();
        }

        private void Predkosc1_CheckedChanged(object sender, EventArgs e)
        {
            szybkosc = 0.25;
        }

        private void Predkosc2_CheckedChanged(object sender, EventArgs e)
        {
            szybkosc = 0.5;
        }

        private void Predkosc3_CheckedChanged(object sender, EventArgs e)
        {
            szybkosc = 1;
        }

        private void Predkosc4_CheckedChanged(object sender, EventArgs e)
        {
            szybkosc = 2;
        }

        private void Predkosc5_CheckedChanged(object sender, EventArgs e)
        {
            szybkosc = 4;
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            Config.Zapisz(szybkosc);
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
