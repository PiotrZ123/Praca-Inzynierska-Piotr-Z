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
    public partial class WyborPoziomow : Form
    {
        public WyborPoziomow()
        {
            InitializeComponent();
            SprawdzPrzyciski();
        }

        private void SprawdzPrzyciski()
        {
            Poziom2Button.Enabled = true;
            Poziom3Button.Enabled = true;
            Poziom4Button.Enabled = true;
            Poziom5Button.Enabled = true;
            if (Config.Odczytaj("Poziom") <= 1) Poziom2Button.Enabled = false;
            if (Config.Odczytaj("Poziom") <= 2) Poziom3Button.Enabled = false;
            if (Config.Odczytaj("Poziom") <= 3) Poziom4Button.Enabled = false;
            if (Config.Odczytaj("Poziom") <= 4) Poziom5Button.Enabled = false;
            if (Config.Odczytaj("Poziom") >= 6) WygranaLabel.Visible = true;
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BitwaNiestandardowaButton_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony");
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(graczlewy);
            Bohater Prawy = new Bohater(graczprawy);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy,graczprawy,0,true,Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }

        private void Poziom1Button_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony", 2000);
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(1,1,graczlewy);
            Bohater Prawy = new Bohater(10,10,graczprawy);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy,4,10),0);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 4, 10), 1);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy, graczprawy, 2, false, Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }

        private void Poziom2Button_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony", 3000);
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(1, 1, graczlewy);
            Bohater Prawy = new Bohater(10, 10, graczprawy);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 7, 10), 0);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 7, 10), 1);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 7, 10), 2);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 7, 10), 3);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy, graczprawy, 3, false, Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }

        private void Poziom3Button_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony", 4000);
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(1, 1, graczlewy);
            Bohater Prawy = new Bohater(10, 10, graczprawy);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 12, 20), 0);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 4, 10), 1);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy, graczprawy, 4, false, Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }

        private void Poziom4Button_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony", 6000);
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(1, 1, graczlewy);
            Bohater Prawy = new Bohater(10, 10, graczprawy);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 16, 5), 0);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy, graczprawy, 5, false, Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }

        private void Poziom5Button_Click(object sender, EventArgs e)
        {
            Gracz graczlewy, graczprawy;
            graczlewy = new Gracz("Gracz1", "Czerwony", 4000);
            graczprawy = new Gracz("Gracz2", "Zielony");
            Bohater Lewy = new Bohater(1, 1, graczlewy);
            Bohater Prawy = new Bohater(10, 10, graczprawy);
            Prawy.dodaj_jednostke(BazaJednostek.dajPoNumerze(graczprawy, 18, 5), 0);
            ZakupArmiiPrzedBitwa opcje = new ZakupArmiiPrzedBitwa(graczlewy, graczprawy, 6, false, Lewy, Prawy);
            opcje.ShowDialog();
            SprawdzPrzyciski();
        }
    }
}
