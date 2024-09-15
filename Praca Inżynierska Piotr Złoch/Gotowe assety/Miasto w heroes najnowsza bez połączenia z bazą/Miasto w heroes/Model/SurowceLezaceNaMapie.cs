using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDanych.Bazowy;

namespace Miasto_w_heroes.Model
{
    public class SurowceLezaceNaMapie : BazowyModel, ObiektNaMapie
    {
        Mapa mapa;
        public SurowceLezaceNaMapie(int x, int y,Mapa mapa1)
        {
            PolozenieX = x;
            PolozenieY = y;
            mapa = mapa1;
        }

        Random rnd = new Random();
        public void AkcjaPoKliknieciu(Gra gra)
        {
            //nic sie nie dzieje
        }

        public void Interakcja(Bohater bohater)
        {
            int Gold = rnd.Next(500, 2000);
            bohater.Wlasciciel.Zloto += Gold;
            mapa.UsunObiektNaMapie(PolozenieX,PolozenieY);
            
        }

        public void Rysuj(Graphics grafika)
        {
            grafika.DrawImage(Image.FromFile(@"..\..\grafika\zloto.png"), (PolozenieX * 40), (PolozenieY * 40), 40, 40);
        }
    }
}
