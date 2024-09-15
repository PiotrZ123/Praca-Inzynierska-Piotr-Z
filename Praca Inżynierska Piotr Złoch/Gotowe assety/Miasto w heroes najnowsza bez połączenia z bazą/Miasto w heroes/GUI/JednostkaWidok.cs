using Miasto_w_heroes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miasto_w_heroes.GUI
{
    public partial class JednostkaWidok : Form
    {
        bool czymoznaUpgrade;
        bool czymoznadegradacja;
        bool CzyMoznaZwolnic;
        public int Result { get; set; }
        public JednostkaWidok(Jednostka jednostka,bool czymoznaUpgrade1,bool czymoznadegradacja1,bool CzyMoznaZwolnic1)
        {
            InitializeComponent();
            Result = 0;
            jednostkaWidokKontrolka1.Inicjuj(jednostka);
            czymoznaUpgrade = czymoznaUpgrade1;
            czymoznadegradacja = czymoznadegradacja1;
            CzyMoznaZwolnic = CzyMoznaZwolnic1;
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Result = 0;
            Close();
        }

        private void ZwolnijButton_Click(object sender, EventArgs e)
        {
            if (CzyMoznaZwolnic == true)
            {
                Result = 1;
                Close();
            }
        }

        private void DegradujJednostkeButton_Click(object sender, EventArgs e)
        {
            if (czymoznadegradacja == true)
            {
                Result = 2;
                Close();
            }
        }

        private void UlepszenieButton_Click(object sender, EventArgs e)
        {
            if (czymoznaUpgrade == true)
            {
                Result = 3;
                Close();
            }
        }
    }
}
