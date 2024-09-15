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
    public partial class WygranaPrzegrana : Form
    {
        public WygranaPrzegrana(bool Wygrana)
        {
            InitializeComponent();
            if (Wygrana == true)
            {
                label1.Text = "Wygrana";
                label1.ForeColor = Color.Green;
            }
            else if (Wygrana == false)
            {
                label1.Text = "Przegrana";
                label1.ForeColor = Color.Red;
            }
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
