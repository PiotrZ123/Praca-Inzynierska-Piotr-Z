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
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void WyborPoziomuButton_Click(object sender, EventArgs e)
        {
            WyborPoziomow opcje = new WyborPoziomow();
            opcje.ShowDialog();
        }

        private void OpcjeButton_Click(object sender, EventArgs e)
        {
            Opcje opcje = new Opcje();
            opcje.ShowDialog();
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
