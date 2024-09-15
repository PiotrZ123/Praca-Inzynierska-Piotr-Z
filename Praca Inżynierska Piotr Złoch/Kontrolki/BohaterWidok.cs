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

namespace Praca_Inżynierska_Piotr_Złoch.Kontrolki
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
