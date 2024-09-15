using Miasto_w_heroes.GUI;
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

namespace Miasto_w_heroes.Kontrolki
{
    public delegate void ZmianaZaznaczeniaJednostkiWBochaterzeEventHandler(BohaterArmia kontrolka, int index);
    


    public partial class BohaterArmia : UserControl
    {
        private JednostkaKontrolka[] jednostki;
        private int indexZaznaczonej;
        private Bohater bohater;
        private bool reagujNaZmianeZaznaczenia;
        public BohaterArmia()
        {
            InitializeComponent();
            reagujNaZmianeZaznaczenia = false;
            jednostki = new JednostkaKontrolka[5];
            jednostki[0] = jednostkaKontrolka1;
            jednostki[1] = jednostkaKontrolka2;
            jednostki[2] = jednostkaKontrolka3;
            jednostki[3] = jednostkaKontrolka4;
            jednostki[4] = jednostkaKontrolka5;
            indexZaznaczonej = -1;
            reagujNaZmianeZaznaczenia = false;
            bohater = new Bohater();
        }
        public event ZmianaZaznaczeniaJednostkiWBochaterzeEventHandler ZmianaZaznaczeniaEvent;
        public void Initialize()
        {
            for (int i = 0; i < jednostki.Length; i++)
            {
                jednostki[i].Initialize(i);
                jednostki[i].ZmianaZaznaczeniaEvent += ZmianaZaznaczeniaJednostki;
            }
            reagujNaZmianeZaznaczenia = true;
        }

        public void Odznacz()
        {
            reagujNaZmianeZaznaczenia = false;
            if (indexZaznaczonej != -1)
            {
                jednostki[indexZaznaczonej].Zaznaczenie = false;
            }
            indexZaznaczonej = -1;
            reagujNaZmianeZaznaczenia = true;
        }

        public void Odznacz(int index)
        {
            reagujNaZmianeZaznaczenia = false;
            jednostki[index].Zaznaczenie = false;
            reagujNaZmianeZaznaczenia = true;
        }

        void ZmianaZaznaczeniaJednostki(int index)
        {
            if (!reagujNaZmianeZaznaczenia)
            {
                return;
            }
            if (jednostki[index].Zaznaczenie)
            {

                if(indexZaznaczonej!=-1)
                {
                    if(indexZaznaczonej== index)
                    {
                        indexZaznaczonej = -1;
                        return;
                    }
                    Jednostka j1 = jednostki[indexZaznaczonej].Jednostka;
                    Jednostka j2 = jednostki[index].Jednostka;


                    if (j1!=null && j2!= null && j1.Numer==j2.Numer)
                    {
                        j2.Ilosc += j1.Ilosc;
                        jednostki[indexZaznaczonej].Jednostka = null;
                        jednostki[index].Jednostka = j2;
                        
                        bohater.dodaj_jednostke(null, indexZaznaczonej);
                        bohater.dodaj_jednostke(j2, index);
                       
                        
                    }
                    else
                    {
                        jednostki[indexZaznaczonej].Jednostka = j2;
                        jednostki[index].Jednostka = j1;
                      
                        bohater.dodaj_jednostke(j2, indexZaznaczonej);
                        bohater.dodaj_jednostke(j1, index);
                        
                    }
                    Odznacz(indexZaznaczonej);
                    Odznacz(index);
                    indexZaznaczonej = -1;
                    return;
                }
              
                indexZaznaczonej = index;
                ZmianaZaznaczeniaEvent(this, index);

            }
            else
            {
                indexZaznaczonej = -1;
            }

           

        }

        public Bohater DajBohatera()
        {
            return bohater;
        }

        public int IndexZaznaczonejJednostki
        {
            get
            {
                return indexZaznaczonej;
            }
            
        }
        public bool Zaznaczenie
        {
            get
            {
                return indexZaznaczonej != -1;
            }
        }


        public void UstawBohatera(Bohater bohater)
        {
            if (bohater != null)
            {
                this.bohater = bohater;
            }
            else
            {
                bohater = new Bohater();
            }
            this.bohater_picturebox.Image = bohater.Portret;
            for (int i = 0; i < jednostki.Length; i++)
            {
                jednostki[i].Jednostka = bohater.DajJednostke(i);
            }
        }
    }
}
