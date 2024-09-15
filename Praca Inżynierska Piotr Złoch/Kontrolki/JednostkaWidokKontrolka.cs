using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praca_Inżynierska_Piotr_Złoch.Logika;

namespace Miasto_w_heroes.Kontrolki
{
    public partial class JednostkaWidokKontrolka : UserControl
    {
        public JednostkaWidokKontrolka()
        {
            InitializeComponent();
        }
        public void UstawJednostke(Jednostka jednostka)
        {
            if (jednostka != null)
            {
                IloscLabel.Text = $"Ilosc: {jednostka.Ilosc}";
                JednostkaPictureBox.Image = jednostka.Portret;
                NumerLabel.Text = $"Numer: {jednostka.Numer}";
                KosztLabel.Text = $"Koszt: {jednostka.Koszt}";
                AtakLabel.Text = $"Atak: {jednostka.Atak}";
                ObronaLabel.Text = $"Obrona: {jednostka.Obrona}";
                ObrazeniaMinLabel.Text = $"ObrazeniaMin: {jednostka.Obrazenia_min}";
                ObrazeniaMaxLabel.Text = $"ObrazeniaMax: {jednostka.Obrazenia_max}";
                MaxZycieLabel.Text = $"MaxZycie: {jednostka.Zycie_max}";
                SzybkoscLabel.Text = $"Szybkosc: {jednostka.Szybkosc}";
                KontratakLabel.Text = $"IloscKontratakow: {jednostka.Kontratak}";
                string czy_strzela;
                if (jednostka.Strzela == true) { czy_strzela = "Tak"; }
                else { czy_strzela = "Nie"; }
                CzyStrzelaLabel.Text = $"Czy strzela: {czy_strzela}";
                IloscStrzalLabel.Text = $"IloscStrzal: {jednostka.Ilosc_strzal}";
                AktualneZycieLabel.Text = $"AktualneZycie: {jednostka.Zycie_aktualne}";
            }
            else
            {
                IloscLabel.Text = "";
                JednostkaPictureBox.Image = null;
                NumerLabel.Text = "";
                KosztLabel.Text = "";
                AtakLabel.Text = "";
                ObronaLabel.Text = "";
                ObrazeniaMinLabel.Text = "";
                ObrazeniaMaxLabel.Text = "";
                MaxZycieLabel.Text = "";
                SzybkoscLabel.Text = "";
                KontratakLabel.Text = "";
                string czy_strzela;
                czy_strzela = "";
                CzyStrzelaLabel.Text = "";
                IloscStrzalLabel.Text = "";
                AktualneZycieLabel.Text = "";
            }
        }
    }
}
