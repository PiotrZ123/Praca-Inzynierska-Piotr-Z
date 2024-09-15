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
    public partial class KsiegaUmiejetnosci : Form
    {
        Jednostka[,] Jednostki;
        Gracz Wlasciciel;
        bool Uzyte = false;
        public KsiegaUmiejetnosci(Jednostka[,] jednostki, Gracz wlasciciel)
        {
            Jednostki = jednostki;
            Wlasciciel = wlasciciel;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtakButton_Click(object sender, EventArgs e)
        {
            BazaUmiejetnosci.UzyjUmiejetnosciPoIndeksie(0, Jednostki, Wlasciciel);
            Uzyte = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BazaUmiejetnosci.UzyjUmiejetnosciPoIndeksie(1, Jednostki, Wlasciciel);
            Uzyte = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BazaUmiejetnosci.UzyjUmiejetnosciPoIndeksie(2, Jednostki, Wlasciciel);
            Uzyte = true;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BazaUmiejetnosci.UzyjUmiejetnosciPoIndeksie(3, Jednostki, Wlasciciel);
            Uzyte = true;
            Close();
        }
        public bool Zwroc()
        {
            return Uzyte;
        }
    }
}
