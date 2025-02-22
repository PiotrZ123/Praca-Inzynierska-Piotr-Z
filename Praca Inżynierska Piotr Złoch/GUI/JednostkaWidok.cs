﻿using Praca_Inżynierska_Piotr_Złoch.Logika;
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
        bool CzyMoznaZwolnic;
        public int Result { get; set; }
        public JednostkaWidok(Jednostka jednostka,bool CzyMoznaZwolnic1)
        {
            InitializeComponent();
            Result = 0;
            jednostkaWidokKontrolka1.UstawJednostke(jednostka);
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
    }
}
