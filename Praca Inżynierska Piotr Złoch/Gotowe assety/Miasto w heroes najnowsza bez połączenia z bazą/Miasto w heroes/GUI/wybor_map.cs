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
    public partial class wybor_map : Form
    {
        public wybor_map()
        {
            InitializeComponent();
        }

        private void Graj_Mape1_button_Click(object sender, EventArgs e)
        {
            Gra gra = Gra.DajInstancje();
            gra.RozpocznijNowaGre();
            Mapa_widok testowy = new Mapa_widok(gra);
            testowy.ShowDialog(this);
        }
    }
}
