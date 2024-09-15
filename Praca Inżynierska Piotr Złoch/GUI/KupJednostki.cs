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
    public partial class KupJednostki : Form
    {
        Gracz gracz;
        int[] Tab = new int[5];
        Jednostka jednostka;
        Bohater bohater;
        public KupJednostki()
        {
            InitializeComponent();
            jednostka0.UstawJednostke(BazaJednostek.dajPoNumerze(gracz,0,0));
            jednostka1.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 4,0));
            jednostka2.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 8,0));
            jednostka3.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 12,0));
            jednostka4.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 16,0));
            for(int i = 0; i < Tab.Length;i++)
            {
                Tab[i] = i*4;
            }
        }
        public KupJednostki(Gracz gracz1,Jednostka jednostka,Bohater bohater)
        {
            InitializeComponent();
            gracz = gracz1;
            this.jednostka = jednostka;
            this.bohater = bohater;
            ZaktualizujPola();
            jednostka0.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 0,0));
            jednostka1.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 4,0));
            jednostka2.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 8,0));
            jednostka3.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 12,0));
            jednostka4.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, 16,0));
            for (int i = 0; i < Tab.Length; i++)
            {
                Tab[i] = i * 4;
            }
        }

        private void ZaktualizujPola()
        {
            if (jednostka == null) IloscTextBox.Text = "0";
            else IloscTextBox.Text = $"{jednostka.Ilosc}";
            ZlotoLabel.Text = $"Złoto: {gracz.Zloto}";
            jednostkaWybrana.UstawJednostke(jednostka);
        }

        private bool CzyMoznaZdegradowac(int numer,int poziomjednostki)
        {
            if (numer > 0+ 4 * poziomjednostki) return true;
            return false;
        }
        private bool CzyMoznaUlepszyc(int numer,int poziomjednostki)
        {
            if (numer < 3+4 * poziomjednostki) return true;
            return false;
        }

        private void JednostkaUlepszButton0_Click(object sender, EventArgs e)
        {
            if (CzyMoznaUlepszyc(Tab[0],0)) Tab[0]+=1 ; jednostka0.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[0],0));
        }

        private void JednostkaDegradujButton1_Click(object sender, EventArgs e)
        {
            if (CzyMoznaZdegradowac(Tab[0],0)) Tab[0] -= 1; jednostka0.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[0],0));
        }

        private void JednostkaUlepszButton1_Click(object sender, EventArgs e)
        {
            if (CzyMoznaUlepszyc(Tab[1],1)) Tab[1] += 1; jednostka1.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[1],0));
        }

        private void JednostkaDegradujButton1_Click_1(object sender, EventArgs e)
        {
            if (CzyMoznaZdegradowac(Tab[1],1)) Tab[1] -= 1; jednostka1.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[1],0));
        }

        private void JednostkaUlepszButton2_Click(object sender, EventArgs e)
        {
            if (CzyMoznaUlepszyc(Tab[2], 2)) Tab[2] += 1; jednostka2.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[2],0));
        }

        private void JednostkaDegradujButton2_Click(object sender, EventArgs e)
        {
            if (CzyMoznaZdegradowac(Tab[2], 2)) Tab[2] -= 1; jednostka2.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[2],0));
        }

        private void JednostkaUlepszButton3_Click(object sender, EventArgs e)
        {
            if (CzyMoznaUlepszyc(Tab[3], 3)) Tab[3] += 1; jednostka3.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[3],0));
        }

        private void JednostkaDegradujButton3_Click(object sender, EventArgs e)
        {
            if (CzyMoznaZdegradowac(Tab[3], 3)) Tab[3] -= 1; jednostka3.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[3],0));
        }

        private void JednostkaUlepszButton4_Click(object sender, EventArgs e)
        {
            if (CzyMoznaUlepszyc(Tab[4], 4)) Tab[4] += 1; jednostka4.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[4],0));
        }

        private void JednostkaDegradujButton4_Click(object sender, EventArgs e)
        {
            if (CzyMoznaZdegradowac(Tab[4], 4)) Tab[4] -= 1; jednostka4.UstawJednostke(BazaJednostek.dajPoNumerze(gracz, Tab[4],0));
        }

        private void WybierzJednostkeZawartosc(int index)
        {
            if (jednostka != null) gracz = jednostka.SprzedajIlosc(gracz, jednostka.Ilosc);
            jednostka = BazaJednostek.dajPoNumerze(gracz, Tab[index],0);
            ZaktualizujPola();
        }

        private void WybierzJednostkeButton0_Click(object sender, EventArgs e)
        {
            WybierzJednostkeZawartosc(0);
        }

        private void WybierzJednostkeButton1_Click(object sender, EventArgs e)
        {
            WybierzJednostkeZawartosc(1);
        }

        private void WybierzJednostkeButton2_Click(object sender, EventArgs e)
        {
            WybierzJednostkeZawartosc(2);
        }

        private void WybierzJednostkeButton3_Click(object sender, EventArgs e)
        {
            WybierzJednostkeZawartosc(3);
        }

        private void WybierzJednostkeButton4_Click(object sender, EventArgs e)
        {
            WybierzJednostkeZawartosc(4);
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Gracz ZwrotGracza()
        {
            return gracz;
        }

        public Bohater ZwrotBohatera()
        {
            return bohater;
        }

        public Jednostka ZwrotJednostki()
        {
            if (jednostka != null&&jednostka.Ilosc <= 0) return null;
            return jednostka;
        }

        private void DodajIloscButton_Click(object sender, EventArgs e)
        {
            if(jednostka!= null)gracz = jednostka.DokupIlosc(gracz,1);
            ZaktualizujPola();
        }

        private void OdejmijIloscButton_Click(object sender, EventArgs e)
        {
            if(jednostka!= null)gracz = jednostka.SprzedajIlosc(gracz, 1);
            ZaktualizujPola();
        }

        private void SprzedajButton_Click(object sender, EventArgs e)
        {
            if(jednostka != null)gracz = jednostka.SprzedajIlosc(gracz, jednostka.Ilosc);
            jednostka = null;
            ZaktualizujPola();
        }
    }
}
