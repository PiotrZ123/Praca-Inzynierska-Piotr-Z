using Miasto_w_heroes.GUI;
using Miasto_w_heroes.Model;
using Miasto_w_heroes.Services;
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
    public delegate void ZmianaZaznaczeniaJednostkiEventHandler(int index);
    
    
    public partial class JednostkaKontrolka : UserControl
    {
        private static Image image;
        private Jednostka jednostka;
        private bool selected;
        private Color baseColor;
        private int index;
        private bool zainicjalizowana;
        public JednostkaKontrolka()
        {
            InitializeComponent();
            zainicjalizowana = false;
            jednostka_w_miescie_picturebox.Visible = false;
           // iloscJednostekLabel.Visible = false;
            baseColor = this.BackColor;
            index = 0;



        }
        public event ZmianaZaznaczeniaJednostkiEventHandler ZmianaZaznaczeniaEvent;

        public void Initialize(int index)
        {
            this.index = index;
            if (image == null)
            {
                image = Obrazy.GetTarcza();
            }
          
            pictureBoxBacgroun.Image = image;
            zainicjalizowana = true;
        }

        public Jednostka Jednostka
        {
            get
            {
                return jednostka;
            }
            set
            {
                jednostka = value;
                if (value != null)
                {
                    jednostka_w_miescie_picturebox.Visible = true;
                    jednostka_w_miescie_picturebox.Image = jednostka.Portret;
                    jednostka_w_miescie_picturebox.BringToFront();
                    iloscJednostekLabel.Visible = true;
                    iloscJednostekLabel.BringToFront();
                    iloscJednostekLabel.Text = jednostka.Ilosc.ToString();
                }
                else
                {
                    jednostka_w_miescie_picturebox.Visible = false;
                    iloscJednostekLabel.Visible = false;
                }
                
            }
        }

        public bool Zaznaczenie
        {
            set
            {
                selected = value;
                if (selected)
                {
                    this.BackColor = Color.Red;
                }
                else
                {
                    this.BackColor = baseColor;
                }
                if(zainicjalizowana)
                {
                    ZmianaZaznaczeniaEvent(index);
                }
                
            }
            get => selected;
        }

        private void jednostka_w_miescie_picturebox_Click(object sender, EventArgs e)
        {
            Zaznaczenie = !Zaznaczenie;
           
        }

        private void pictureBoxBacgroun_Click(object sender, EventArgs e)
        {
            Zaznaczenie = !Zaznaczenie;
            
        }

        private void JednostkaKontrolka_Click(object sender, EventArgs e)
        {
            Zaznaczenie = !Zaznaczenie;
          
        }

        private void jednostka_w_miescie_picturebox_Click_1(object sender, EventArgs e)
        {
            Zaznaczenie = !Zaznaczenie;
        }
    }

  
}
