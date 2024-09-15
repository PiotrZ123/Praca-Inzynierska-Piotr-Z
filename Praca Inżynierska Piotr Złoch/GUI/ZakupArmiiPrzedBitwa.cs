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

namespace Praca_Inżynierska_Piotr_Złoch.GUI
{
    public partial class ZakupArmiiPrzedBitwa : Form
    {
        int numerPoziomu;
        Bohater LewyBohater, PrawyBohater;
        Gracz LewyGracz, PrawyGracz;
        List<Button> listaPrzyciskowJednostekLewy = new List<Button>();
        List<Button> listaPrzyciskowJednostekPrawy = new List<Button>();
        bool CzyNiestandardowa;

        public ZakupArmiiPrzedBitwa(Gracz graczlewy, Gracz graczprawy, int numer, bool czyNiestandardowa, Bohater lewy, Bohater prawy)
        {
            InitializeComponent();
            numerPoziomu = numer;
            LewyBohater = lewy;
            PrawyBohater = prawy;
            LewyGracz = graczlewy;
            PrawyGracz = graczprawy;
            CzyNiestandardowa = czyNiestandardowa;
            if (CzyNiestandardowa == false)
            {
                PrawyDodajAtakButton.Enabled = false;
                PrawyDodajObroneButton.Enabled = false;
                PrawyOdejmijAtakButton.Enabled = false;
                PrawyOdejmijObroneButton.Enabled = false;
                AiCheckBox.Enabled = false;
                PoziomAIKontener.Visible = true;
                PrawyGracz.CzyAi = true;
                LatwyAiButton.Checked = true;
            }
            else
            {
                PoziomAIKontener.Visible = true;
                PrawyGracz.CzyAi = true;
                LatwyAiButton.Checked = true;
            }
            ZaktualizojPola();
            DodajPrzyciski();
            for (int i = 0; i < listaPrzyciskowJednostekLewy.Count; i++)
            {
                int index = i; // Wartość 'i' musi być skopiowana do lokalnej zmiennej
                listaPrzyciskowJednostekLewy[i].Click += (sender, e) => LewyJednostkiKliknieciePrzycisku(index);
            }
            for (int i = 0; i < listaPrzyciskowJednostekPrawy.Count; i++)
            {
                int index = i; // Wartość 'i' musi być skopiowana do lokalnej zmiennej
                listaPrzyciskowJednostekPrawy[i].Click += (sender, e) => PrawyJednostkiKliknieciePrzycisku(index);
            }
        }


        private void LewyJednostkiKliknieciePrzycisku(int index)
        {
            //LewyBohater.SprzedajJednostkeZeSlotu(index);
            KupJednostki formularz = new KupJednostki(LewyGracz,LewyBohater.DajJednostke(index),LewyBohater);
            formularz.ShowDialog();
            LewyBohater = formularz.ZwrotBohatera();
            LewyGracz = formularz.ZwrotGracza();
            LewyBohater.dodaj_jednostke(formularz.ZwrotJednostki(),index);
            ZaktualizojPola();
        }

        private void PrawyJednostkiKliknieciePrzycisku(int index)
        {
            if (CzyNiestandardowa == true)
            {
                int index1;
                if (index > 4) { index1 = index - 5; }
                else { index1 = index + 5; }
                KupJednostki formularz = new KupJednostki(PrawyGracz, PrawyBohater.DajJednostke(index1), PrawyBohater);
                formularz.ShowDialog();
                PrawyBohater = formularz.ZwrotBohatera();
                PrawyGracz = formularz.ZwrotGracza();
                PrawyBohater.dodaj_jednostke(formularz.ZwrotJednostki(), index1);
                ZaktualizojPola();
            }
            
        }

        private void DodajPrzyciski()
        {
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki0);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki1);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki2);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki3);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki4);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki5);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki6);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki7);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki8);
            listaPrzyciskowJednostekLewy.Add(LewyZakupJednostki9);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki0);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki1);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki2);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki3);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki4);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki5);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki6);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki7);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki8);
            listaPrzyciskowJednostekPrawy.Add(PrawyZakupJednostki9);
        }

        private void ZaktualizojPola()
        {
            LewaArmia.UstawBohatera(LewyBohater);
            PrawaArmia.UstawBohatera(PrawyBohater);
            LewyIloscZlotaLabel.Text = $"{LewyGracz.Zloto}";
            PrawyIloscZlotaLabel.Text = $"{PrawyGracz.Zloto}";
            LewyIloscAtakuTextBox.Text = $"{LewyBohater.Atak}";
            LewyIloscObronyTextBox.Text = $"{LewyBohater.Obrona}";
            PrawyIloscAtakuTextBox.Text = $"{PrawyBohater.Atak}";
            PrawyIloscObronyTextBox.Text = $"{PrawyBohater.Obrona}";
            LewyBohaterWidok.UstawBohatera(LewyBohater);
            PrawyBohaterWidok.UstawBohatera(PrawyBohater);
        }
        private bool SprawdzMozliwoscDodaniaStatystyki(int ilosc,Gracz gracz)
        {
            if (ilosc < 99)
            {
                if (gracz.Zloto >= 1000)
                {
                    gracz.Zloto -= 1000;
                    return true;
                }
            }
            return false;
        }
        private bool SprawdzMozliwoscOdjeciaStatystyki(int ilosc, Gracz gracz)
        {
            if (ilosc > 0)
            {
                gracz.Zloto += 1000;
                return true;
            }
            return false;
        }
        private void LewyOdejmijAtakButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscOdjeciaStatystyki(LewyBohater.Atak, LewyGracz);
            if (TakNie == true) LewyBohater.Atak -= 1; ZaktualizojPola();
        }

        private void LewyDodajAtakButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscDodaniaStatystyki(LewyBohater.Atak, LewyGracz);
            if (TakNie == true) LewyBohater.Atak += 1; ZaktualizojPola();
        }

        private void PrawyOdejmijAtakButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscOdjeciaStatystyki(PrawyBohater.Atak, PrawyGracz);
            if (TakNie == true) PrawyBohater.Atak -= 1; ZaktualizojPola();
        }

        private void PrawyDodajAtakButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscDodaniaStatystyki(PrawyBohater.Atak, PrawyGracz);
            if (TakNie == true) PrawyBohater.Atak += 1; ZaktualizojPola();
        }

        private void LewyOdejmijObroneButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscOdjeciaStatystyki(LewyBohater.Obrona, LewyGracz);
            if (TakNie == true) LewyBohater.Obrona -= 1; ZaktualizojPola();
        }

        private void LewyDodajObroneButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscDodaniaStatystyki(LewyBohater.Obrona, LewyGracz);
            if (TakNie == true) LewyBohater.Obrona += 1; ZaktualizojPola();
        }

        private void PrawyOdejmijObroneButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscOdjeciaStatystyki(PrawyBohater.Obrona, PrawyGracz);
            if (TakNie == true) PrawyBohater.Obrona -= 1; ZaktualizojPola();
        }

        private void PrawyDodajObroneButton_Click(object sender, EventArgs e)
        {
            bool TakNie = SprawdzMozliwoscDodaniaStatystyki(PrawyBohater.Obrona, PrawyGracz);
            if (TakNie == true) PrawyBohater.Obrona += 1; ZaktualizojPola();
        }

        private void AiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AiCheckBox.Checked == true)
            {
                PoziomAIKontener.Visible = true;
                PrawyGracz.CzyAi = true;
                LatwyAiButton.Checked = true;
            }
            else
            {
                PoziomAIKontener.Visible = false;
                PrawyGracz.CzyAi = false;
                LatwyAiButton.Checked = false;
                NormalnyAiButton.Checked = false;
                TrudnyAiButon.Checked = false;
            }
        }

        private void LatwyAiButton_CheckedChanged(object sender, EventArgs e)
        {
            PrawyGracz.TrudnoscAi = GraczModel.PoziomAi.Latwy;
        }

        private void NormalnyAiButton_CheckedChanged(object sender, EventArgs e)
        {
            PrawyGracz.TrudnoscAi = GraczModel.PoziomAi.Normalny;
        }

        private void TrudnyAiButon_CheckedChanged(object sender, EventArgs e)
        {
            PrawyGracz.TrudnoscAi = GraczModel.PoziomAi.Trudny;
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RozpocznijBitweButton_Click(object sender, EventArgs e)
        {
            if (LewyBohater.czy_ma_jednostki() == true && PrawyBohater.czy_ma_jednostki() == true)
            {
                Bitwa opcje = new Bitwa(LewyBohater, PrawyBohater, numerPoziomu);
                opcje.ShowDialog();
                Close();
            }
        }
    }
}
