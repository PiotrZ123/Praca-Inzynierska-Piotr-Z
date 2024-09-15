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
    public partial class ArmiaWidok : UserControl
    {
        Bohater bohater;
        public ArmiaWidok()
        {
            InitializeComponent();
        }

        public void UstawBohatera(Bohater bohater)
        {
            this.bohater = bohater;
            UstawJednostki();
        }

        private void UstawJednostki()
        {
            jednostkaWidok1.UstawJednostke(bohater.DajJednostke(0));
            jednostkaWidok2.UstawJednostke(bohater.DajJednostke(1));
            jednostkaWidok3.UstawJednostke(bohater.DajJednostke(2));
            jednostkaWidok4.UstawJednostke(bohater.DajJednostke(3));
            jednostkaWidok5.UstawJednostke(bohater.DajJednostke(4));
            jednostkaWidok6.UstawJednostke(bohater.DajJednostke(5));
            jednostkaWidok7.UstawJednostke(bohater.DajJednostke(6));
            jednostkaWidok8.UstawJednostke(bohater.DajJednostke(7));
            jednostkaWidok9.UstawJednostke(bohater.DajJednostke(8));
            jednostkaWidok10.UstawJednostke(bohater.DajJednostke(9));
        }
    }
}
