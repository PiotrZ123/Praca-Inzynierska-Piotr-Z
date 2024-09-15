using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolki_by_wwsi
{
    public partial class Pasek_postępu: UserControl
    {
        double obecna_wartosc;
        double max_wartosc;
        public delegate void pusty_pasek();
        public event pusty_pasek wartosc_zerowa;
        public Pasek_postępu()
        {
            InitializeComponent();
            wartosc_zerowa += pokaz_zero;
        }
        public double Obecna_wartosc
        {
            get { return obecna_wartosc; }
            set { obecna_wartosc = value; Refresh(); label.Visible = false; if (obecna_wartosc <= 0) { wartosc_zerowa?.Invoke(); } }
        }
        public double Max_wartosc
        {
            get { return max_wartosc; }
            set { max_wartosc = value;  Refresh();}
        }

        private SolidBrush kolor = new SolidBrush(Color.Blue);

        public Color Kolor
        {
            get { return kolor.Color; }
            set { kolor.Color = value; Refresh(); }
        }


        private void pokaz_zero()
        {
            label.Visible = true;
        }


        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));
            double szerokosc = Width * (obecna_wartosc / max_wartosc);
            e.Graphics.FillRectangle(kolor,new Rectangle(2,2, (int)(szerokosc -4), Height - 4));

        }
    }
}
