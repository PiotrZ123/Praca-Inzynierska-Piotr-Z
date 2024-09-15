using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miasto_w_heroes.Model;

namespace Miasto_w_heroes.Kontrolki
{
    public partial class BohaterWidok : UserControl
    {
        public BohaterWidok()
        {
            InitializeComponent();
        }

        public void UstawBohatera(Bohater bohater)
        {
            BohaterPicturebox.Image = bohater.Portret;
            BohaterAtakLabel.Text = $"atak: {bohater.Atak}";
            BohaterObronaLabel.Text = $"obrona: {bohater.Obrona}";
        }
    }
}
