using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animacje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile($@"..\..\Animacja\j1_1_atak\" + 2 + ".png");
            Animacja animacja = new Animacja(1,0);
            animacja.RysujRaz(this.CreateGraphics(), 1,1);
            //animacja.RysujCiagleAsync(this.CreateGraphics(), 3, 3);
        }
    }
}
