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
    public partial class KolejkaJednostek : UserControl
    {
        Graphics g;
        public KolejkaJednostek()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        public void Odswierz(Bohater Lewy, Bohater Prawy, Jednostka AktualnaJednostka)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Lewy.Jednostki[i]!=null)
                {
                    g.DrawImage(Lewy.Jednostki[i].Portret, i * 2 * 50, 0, 50, 50);
                    if (AktualnaJednostka == Lewy.Jednostki[i])
                        using (Pen pen = new Pen(Color.Red, 4))
                        {
                        g.DrawRectangle(pen, (i*2*50)+1, 2, 47, 47); 
                        }
                }
                if(Prawy.Jednostki[i]!= null)
                {
                    g.DrawImage(Prawy.Jednostki[i].Portret, ((i * 2) + 1) * 50, 0, 50, 50);
                    if (AktualnaJednostka == Prawy.Jednostki[i])
                        using (Pen pen = new Pen(Color.Red, 4))
                        {
                            g.DrawRectangle(pen, (((i * 2)+1) * 50)+1, 2, 47, 47);
                        }
                }
            }
        }
    }
}
