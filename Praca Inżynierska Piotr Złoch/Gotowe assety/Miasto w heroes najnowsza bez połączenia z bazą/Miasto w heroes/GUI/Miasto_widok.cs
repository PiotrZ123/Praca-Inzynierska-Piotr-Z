using Miasto_w_heroes.GUI;
using Miasto_w_heroes.Kontrolki;
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

namespace Miasto_w_heroes
{
    public partial class Miasto_widok : Form
    {
        enum ZaznaczonyBohater
        {
            pusty, wMiescie,pozaMiastem
        }
        private Miasto miasto;
        private ZaznaczonyBohater zaznaczonyBohater;

        public Miasto_widok(Miasto miasto)
        {
            InitializeComponent();
            this.miasto = miasto;
            zaznaczonyBohater = ZaznaczonyBohater.pusty;
            OdswierzBudynki();

            wlasciciel_label.Text = $"wlasciciel: {miasto.Wlasciciel.Imie}";
            gold_label.Text = $"ilosc zlota : {miasto.Wlasciciel.Zloto}";
            
        }
        Bohater bohater;
      
        public void Inicjalizuj(Bohater bohater)
        {
            bohaterControl1.Initialize();
            bohaterControl2.Initialize();

            miasto.BohaterWMiescie.PrzywrocPortretyJednostkom();
            this.bohater = bohater;
            if (bohater!= null) { bohater.PrzywrocPortretyJednostkom(); }

            bohaterControl1.UstawBohatera(miasto.BohaterWMiescie);
            bohaterControl2.UstawBohatera(bohater);

            
            bohaterControl1.ZmianaZaznaczeniaEvent += ZaznaczenieJednostkiBohatera1;
            bohaterControl2.ZmianaZaznaczeniaEvent += ZaznaczenieJednostkiBohatera2;
        }

        private void OdswierzFormularz()
        {
            bohaterControl1.UstawBohatera(miasto.BohaterWMiescie);
            bohaterControl2.UstawBohatera(bohater);
            wlasciciel_label.Text = $"wlasciciel: {miasto.Wlasciciel.Imie}";
            gold_label.Text = $"ilosc zlota : {miasto.Wlasciciel.Zloto}";
        }

        private void ZaznaczenieJednostkiBohatera1(BohaterArmia kontrolka, int index)
        {
            if(!kontrolka.Zaznaczenie)
            {
                if (zaznaczonyBohater == ZaznaczonyBohater.wMiescie)
                {
                    zaznaczonyBohater = ZaznaczonyBohater.pusty;
                }

                return;
            }

            if (zaznaczonyBohater == ZaznaczonyBohater.wMiescie)
            {
                return;
            }
            if (zaznaczonyBohater == ZaznaczonyBohater.pusty)
            {
                zaznaczonyBohater = ZaznaczonyBohater.wMiescie;
                return;
            }
            if (zaznaczonyBohater == ZaznaczonyBohater.pozaMiastem && bohaterControl1.IndexZaznaczonejJednostki != -1 && bohaterControl2.IndexZaznaczonejJednostki != -1)//z bohatera do miasta
            {
                zaznaczonyBohater = ZaznaczonyBohater.pusty;

                Bohater bohaterWMiescie = bohaterControl1.DajBohatera();
                Bohater bohaterPozaMiastem = bohaterControl2.DajBohatera();
                int indexJednoskiWMiescie = bohaterControl1.IndexZaznaczonejJednostki;
                int indexJednoskiPozaMiastem = bohaterControl2.IndexZaznaczonejJednostki;
                Jednostka jednoskaWMiescie = bohaterWMiescie.Jednostki[indexJednoskiWMiescie];
                Jednostka jednoskaPozaMiastem = bohaterPozaMiastem.Jednostki[indexJednoskiPozaMiastem];

                if (jednoskaWMiescie == null && jednoskaPozaMiastem == null)
                {
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }
                if (jednoskaWMiescie == null && jednoskaPozaMiastem != null && bohaterPozaMiastem.MaTylkoJedenTypJednostek())
                {
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }

                if (jednoskaWMiescie != null && jednoskaPozaMiastem != null &&
                   jednoskaWMiescie.Numer == jednoskaPozaMiastem.Numer)
                {
                    if(bohaterPozaMiastem.MaTylkoJedenTypJednostek())
                    {
                        bohaterControl1.Odznacz();
                        bohaterControl2.Odznacz();
                        return;
                    }

                    jednoskaWMiescie.Ilosc += jednoskaPozaMiastem.Ilosc;
                    bohaterPozaMiastem.Jednostki[indexJednoskiPozaMiastem] = null;
                    

                    bohaterControl1.UstawBohatera(bohaterWMiescie);
                    bohaterControl2.UstawBohatera(bohaterPozaMiastem);
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }

                bohaterWMiescie.Jednostki[indexJednoskiWMiescie] = jednoskaPozaMiastem;
                bohaterPozaMiastem.Jednostki[indexJednoskiPozaMiastem] = jednoskaWMiescie;
                bohaterControl1.UstawBohatera(bohaterWMiescie);
                bohaterControl2.UstawBohatera(bohaterPozaMiastem);
                bohaterControl1.Odznacz();
                bohaterControl2.Odznacz();
            }
        }

        private void ZaznaczenieJednostkiBohatera2(BohaterArmia kontrolka, int index)
        {
            if (!kontrolka.Zaznaczenie)
            {
                if (zaznaczonyBohater == ZaznaczonyBohater.pozaMiastem)
                {
                    zaznaczonyBohater = ZaznaczonyBohater.pusty;
                }

                return;
            }

            if (kontrolka.DajBohatera().Nieosobowy)
            {
                kontrolka.Odznacz();
                return;
            }
            if(zaznaczonyBohater == ZaznaczonyBohater.pozaMiastem)
            {
                return;
            }
            if(zaznaczonyBohater == ZaznaczonyBohater.pusty)
            {
                zaznaczonyBohater = ZaznaczonyBohater.pozaMiastem;
                return;
            }
            if(zaznaczonyBohater == ZaznaczonyBohater.wMiescie && bohaterControl1.IndexZaznaczonejJednostki != -1 && bohaterControl2.IndexZaznaczonejJednostki != -1)//z miasta do bohatera
            {
                zaznaczonyBohater = ZaznaczonyBohater.pusty;
                
                Bohater bohaterWMiescie = bohaterControl1.DajBohatera();
                Bohater bohaterPozaMiastem = bohaterControl2.DajBohatera();
                int indexJednoskiWMiescie = bohaterControl1.IndexZaznaczonejJednostki;
                int indexJednoskiPozaMiastem = bohaterControl2.IndexZaznaczonejJednostki;
                Jednostka jednoskaWMiescie = bohaterWMiescie.Jednostki[indexJednoskiWMiescie];
                Jednostka jednoskaPozaMiastem = bohaterPozaMiastem.Jednostki[indexJednoskiPozaMiastem];

                if (jednoskaWMiescie == null && jednoskaPozaMiastem==null)
                {
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }
                if (jednoskaWMiescie == null && jednoskaPozaMiastem!=null && bohaterPozaMiastem.MaTylkoJedenTypJednostek())
                {
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }
                if(jednoskaWMiescie!=null && jednoskaPozaMiastem!=null &&
                   jednoskaWMiescie.Numer == jednoskaPozaMiastem.Numer)
                {
                    jednoskaPozaMiastem.Ilosc += jednoskaWMiescie.Ilosc;
                    bohaterWMiescie.Jednostki[indexJednoskiWMiescie] = null;
                    bohaterControl1.UstawBohatera(bohaterWMiescie);
                    bohaterControl2.UstawBohatera(bohaterPozaMiastem);
                    bohaterControl1.Odznacz();
                    bohaterControl2.Odznacz();
                    return;
                }

                bohaterWMiescie.Jednostki[indexJednoskiWMiescie] = jednoskaPozaMiastem;
                bohaterPozaMiastem.Jednostki[indexJednoskiPozaMiastem] = jednoskaWMiescie;
                bohaterControl1.UstawBohatera(bohaterWMiescie);
                bohaterControl2.UstawBohatera(bohaterPozaMiastem);
                bohaterControl1.Odznacz();
                bohaterControl2.Odznacz();
            }
        }

     

        private Jednostka DajZaznaczonaJednostke(BohaterArmia bohaterControl)
        {
            Bohater bohater = bohaterControl.DajBohatera();
            if (bohaterControl.IndexZaznaczonejJednostki != -1)
            {
                return bohater.Jednostki[bohaterControl.IndexZaznaczonejJednostki];
            }
            return null;
        }


        private int DajZaznaczonego(BohaterArmia kontrolka)
        {
            if (kontrolka == bohaterControl1)
            {
                return 1;
            }
            return 2;
        }

        private void OdswierzBudynki()
        {
            ladowanie_budynkow(0, miasto, Budynek_0);
            ladowanie_budynkow(1, miasto, Budynek_1);
            ladowanie_budynkow(2, miasto, Budynek_2);
            ladowanie_budynkow(3, miasto, Budynek_3);
            ladowanie_budynkow(4, miasto, Budynek_4);
            ladowanie_budynkow(5, miasto, Budynek_5);
            ladowanie_budynkow(6, miasto, Budynek_6);
            ladowanie_budynkow(7, miasto, Budynek_7);
            ladowanie_budynkow(8, miasto, Budynek_8);
            ladowanie_budynkow(9, miasto, Budynek_9);
        }
       

        private void ladowanie_budynkow(int i,Miasto Miasto1, Button Button)
        {
                int budynek = Miasto1.Sprawdzenie_budynku(i);
                if (budynek == 0) { Button.Image = Properties.Resources.Strzałka; }
                else if (budynek == 1) { Button.Image = Properties.Resources.b0; }
                else if (budynek == 2) { Button.Image = Properties.Resources.b1; }
                else if (budynek == 3) { Button.Image = Properties.Resources.b2; }
                else if (budynek == 4) { Button.Image = Properties.Resources.b3; }
                else if (budynek == 5) { Button.Image = Properties.Resources.b4; }
        }

        private void zamknij_button_Click(object sender, EventArgs e)
        {
           // miasto.usun_bohatera_poza_zamkiem();
            Close();
        }

        private void BudowaBudynku(int index)
        {
            int q = miasto.Sprawdzenie_budynku(index);
            if (q < 5 & q >= 0)
            {
                Budowa_budynku budynekView = new Budowa_budynku(miasto, index);
                budynekView.ShowDialog(this);
                OdswierzFormularz();
                OdswierzBudynki();
            }
        }

         private void Budynek_0_Click(object sender, EventArgs e)
         {
            BudowaBudynku(0);
         }

        private void Budynek_1_Click(object sender, EventArgs e)
        {
            BudowaBudynku(1);
        }

        private void Budynek_2_Click(object sender, EventArgs e)
        {
            BudowaBudynku(2);
        }

        private void Budynek_3_Click(object sender, EventArgs e)
        {
            BudowaBudynku(3);
        }

        private void Budynek_4_Click(object sender, EventArgs e)
        {
            BudowaBudynku(4);
        }

        private void Budynek_5_Click(object sender, EventArgs e)
        {
            BudowaBudynku(5);
        }

        private void Budynek_6_Click(object sender, EventArgs e)
        {
            BudowaBudynku(6);
        }

        private void Budynek_7_Click(object sender, EventArgs e)
        {
            BudowaBudynku(7);
        }

        private void Budynek_8_Click(object sender, EventArgs e)
        {
            BudowaBudynku(8);
        }

        private void Budynek_9_Click(object sender, EventArgs e)
        {
            BudowaBudynku(9);
        }

        private void Rekrutacja_button_Click(object sender, EventArgs e)
        {
            Ekran_rekrutacji rekrutacja = new Ekran_rekrutacji(miasto);
            rekrutacja.ShowDialog(this);
            bohaterControl1.UstawBohatera(miasto.BohaterWMiescie);
            OdswierzFormularz();
        }

        private void JednostkaWMiescieZawartosc(int NumerJednostki)
        {
            if (miasto.BohaterWMiescie.Jednostki[NumerJednostki] != null)
            {
                bohaterControl1.Odznacz();
                bohaterControl2.Odznacz();
                bool CzyJednostkaDoUpgrade = miasto.CzyMoznaUpgradowacJednostkeNaPodstawieNumeru(miasto.BohaterWMiescie.Jednostki[NumerJednostki].Numer);
                JednostkaWidok rekrutacja = new JednostkaWidok(miasto.BohaterWMiescie.Jednostki[NumerJednostki],CzyJednostkaDoUpgrade, true, true);
                rekrutacja.ShowDialog(this);
                int rezultat = rekrutacja.Result;
                if (rezultat == 1) { miasto.BohaterWMiescie.Jednostki[NumerJednostki] = null; }//jeszcze nie dziala
                else if (rezultat == 2) { miasto.BohaterWMiescie.Jednostki[NumerJednostki].DegradajcaJednostki(); }
                else if (rezultat == 3) { miasto.BohaterWMiescie.Jednostki[NumerJednostki].UpgradeJednostki(); }
                OdswierzFormularz();
            }
        }

        private void JednostkaWMiescie1_Click(object sender, EventArgs e)
        {
            JednostkaWMiescieZawartosc(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JednostkaWMiescieZawartosc(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JednostkaWMiescieZawartosc(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JednostkaWMiescieZawartosc(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JednostkaWMiescieZawartosc(4);
        }
    }
}
