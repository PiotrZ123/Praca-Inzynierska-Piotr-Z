using ModelDanych.Bazowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    public class Mapa : MapaBazowyModel
    {
        public int Id { get; set; }
        public List<Bohater> Bohaterowie { get; set; }
        public List<Miasto> Miasta { get; set; }
        public List<Gracz> Gracze { get; set; }
        public List<SurowceLezaceNaMapie> Surowce { get; set; }

        public ObiektNaMapie[,] Przeszkody { get; set; }

        private Dictionary<string, Gracz> slownikWlascicieli;

        public Mapa()
        {
            Bohaterowie = new List<Bohater>();
            Miasta = new List<Miasto>();
            Gracze = new List<Gracz>();
            Surowce = new List<SurowceLezaceNaMapie>();
            IndexNowegoBohatera = 0;
            Dzien = 0;
        }

        public void Inicjuj()
        {
            slownikWlascicieli = new Dictionary<string, Gracz>();
            foreach (Gracz g in Gracze)
            {
                slownikWlascicieli.Add(g.NumerGuid, g);
            }


            Przeszkody = new ObiektNaMapie[1000, 1000];
            foreach (Miasto miasto in Miasta)
            {
                InicjujMiasto(miasto);
            }
            foreach (Bohater bohater in Bohaterowie)
            {
                int x = bohater.PolozenieX;
                int y = bohater.PolozenieY;
                Przeszkody[x, y] = bohater;
            }
            foreach (SurowceLezaceNaMapie surowiec in Surowce)
            {
                int x = surowiec.PolozenieX;
                int y = surowiec.PolozenieY;
                Przeszkody[x, y] = surowiec;
            }
        }

        public void UsunObiektNaMapie(int x, int y)
        {
            Przeszkody[x, y] = null;
        }

        public void UsunBohatera(Bohater bohater1)
        {
            /*
            foreach (Bohater bohater in Bohaterowie)
            {
                Bohaterowie.Remove(bohater1);
            }*/

            for (int i = 0; i < Bohaterowie.Count; i++)
            {
                int x = bohater1.PolozenieX;
                int y = bohater1.PolozenieY;
                Przeszkody[x, y] = null;
                Bohaterowie.Remove(bohater1);
            }
            /*
            for (int i = 0; i< Bohaterowie.Count;i++)
            {
                if (Bohaterowie[i] == bohater1)
                {
                    Bohaterowie.Remove(Bohaterowie[i]);
                    Bohaterowie[i] = null;
                    Bohaterowie.RemoveAt(i);
                }
            }*/
        }

        public Gracz DajWlasiciela(string guid)
        {
            return slownikWlascicieli[guid];
        }

        void InicjujMiasto(Miasto miasto)
        {
            int x = miasto.PolozenieX;
            int y = miasto.PolozenieY;
            Przeszkody[x, y] = miasto;
            Przeszkody[x + 1, y] = new PrzeszkodaMiasto(miasto);
            Przeszkody[x - 1, y] = new PrzeszkodaMiasto(miasto);
            Przeszkody[x + 1, y - 1] = new PrzeszkodaMiasto(miasto);
            Przeszkody[x - 1, y - 1] = new PrzeszkodaMiasto(miasto);
            Przeszkody[x, y - 1] =new PrzeszkodaMiasto(miasto);
        }
        
    }

}
