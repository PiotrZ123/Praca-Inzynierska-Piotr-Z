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
    public partial class JednostkaWidok : UserControl
    {
        public JednostkaWidok()
        {
            InitializeComponent();
        }

        public void UstawJednostke(Jednostka jednostka)
        {
            if (jednostka != null)
            {
                JednostkaPictureBox.Image = jednostka.Portret;
                LiczbaJednostekLabel.Text = $"{ jednostka.Ilosc}";
            }
            else
            {
                JednostkaPictureBox.Image = null;
                LiczbaJednostekLabel.Text = "0";
            }
        }
    }
}
