using Miasto_w_heroes.Model;
using Miasto_w_heroes.Services;
using ModelDanych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaDostępuDoDanych;

namespace Miasto_w_heroes
{
    public class Gra
    {
        private Mapa mapa;
        private ListaGraca<Miasto> miastaGracza;
        private ListaGraca<Bohater> bohaterowieGracza;
        private Gracz aktualnyGracz;
        private BazaJednostek bazaJednostek;
        private BazaBohaterow bazaBohaterow;

      

        private static Gra instancja;
        public static Gra DajInstancje()
        {
            if(instancja == null)
            {
                instancja = new Gra();
            }
            return instancja;
        }
        private Gra()
        {

        }
        public void RozpocznijNowaGre()
        {
            mapa = new Mapa();
            mapa.Gracze.Add(new Gracz("Gracz1", "czerwony"));
            mapa.Gracze.Add(new Gracz("Gracz2", "zielony"));
            mapa.Gracze.Add(new Gracz("Gracz3", "niebieski"));
            mapa.Gracze.Add(new Gracz("Gracz4", "fioletowy"));
            mapa.Miasta.Add(new Miasto(3, 3, mapa.Gracze[0]));
            mapa.Miasta.Add(new Miasto(10, 10, null));

            bazaJednostek = new BazaJednostek();
            bazaBohaterow = new BazaBohaterow(mapa.IndexNowegoBohatera, bazaJednostek);

            mapa.Bohaterowie.Add(bazaBohaterow.DajBohatera(mapa.Gracze[0], 1, 1));
            mapa.Bohaterowie.Add(bazaBohaterow.DajBohatera(mapa.Gracze[1], 1, 2));
            mapa.Bohaterowie.Add(bazaBohaterow.DajBohatera(mapa.Gracze[2], 1, 3));
            mapa.Bohaterowie.Add(bazaBohaterow.DajBohatera(mapa.Gracze[3], 1, 4));
            mapa.Bohaterowie.Add(bazaBohaterow.DajBohatera(mapa.Gracze[0], 1, 5));

            mapa.Surowce.Add(new SurowceLezaceNaMapie(6,6,this.mapa));



            mapa.Inicjuj();

            //MapaModel mapaModel = Logic.DajInstancje().Convert(mapa);
            //Mapa mapa2 = Logic.DajInstancje().Convert(mapaModel);

           miastaGracza = new ListaGraca<Miasto>(mapa.Miasta);
            bohaterowieGracza = new ListaGraca<Bohater>(mapa.Bohaterowie);
            aktualnyGracz = mapa.Gracze[0];
        }

        public void Zapisz()
        {
            Converter c = new Converter();
            MapaModel model = c.Convert(mapa);
            BazaDanych bazaDanych = new BazaDanych();
            bazaDanych.Zapisz(model);
        }
        public List<MapaModel> WczytajListeZapisow()
        {
            BazaDanych bazaDanych = new BazaDanych();
            return bazaDanych.WczytajMapy();
        }

        public void Wczytaj(int id)
        {
            BazaDanych bazaDanych = new BazaDanych();
            MapaModel model = bazaDanych.Wczytaj(id);

            Converter c = new Converter();
            mapa = c.Convert(model);
            mapa.Inicjuj();

            miastaGracza = new ListaGraca<Miasto>(mapa.Miasta);
            bohaterowieGracza = new ListaGraca<Bohater>(mapa.Bohaterowie);
            aktualnyGracz = mapa.Gracze[0];
        }

        public void Usun(int id)
        {
            BazaDanych bazaDanych = new BazaDanych();
            bazaDanych.Usun(id);
        }
        public Bohater AktualnyBohater { get; set; }
        public BazaJednostek BazaJednostek => bazaJednostek;
        public BazaBohaterow BazaBohaterow => bazaBohaterow;

        public List<Miasto> MiastaGracza
        {
            get
            {
                return miastaGracza.DajListeDlaGracza(aktualnyGracz);
            }
        }
        public List<Bohater> BohaterowieGracza
        {
            get
            {
                return bohaterowieGracza.DajListeDlaGracza(aktualnyGracz);
            }
        }

        public Mapa Mapa
        {
            get
            {
                return mapa;
            }
        }

        public void Ruch(int x, int y)
        {
            if(AktualnyBohater==null||AktualnyBohater.Ilosc_ruchu < 50)
            {
                return;
            }
            int x1 = AktualnyBohater.PolozenieX + x;
            int y1 = AktualnyBohater.PolozenieY + y;
            if (x1 < 0 || Mapa.Przeszkody.GetLength(0)< x1)
            {
                return;
            }
            if (y1 < 0 || Mapa.Przeszkody.GetLength(1) < y1)
            {
                return;
            }
            

            int x2 = AktualnyBohater.PolozenieX;
            int y2 = AktualnyBohater.PolozenieY;
            if(Mapa.Przeszkody[x1, y1] == null)
            {
                Mapa.Przeszkody[x2, y2] = null;
                Mapa.Przeszkody[x1, y1] = AktualnyBohater;
                AktualnyBohater.PolozenieX = x1;
                AktualnyBohater.PolozenieY = y1;
                AktualnyBohater.wykonaj_ruch(50);
            }
            else
            {
                Mapa.Przeszkody[x1, y1].Interakcja(AktualnyBohater);
                Bohater bohater = Mapa.Przeszkody[x1, y1] as Bohater;
                if (bohater is  Bohater)
                {
                    if (AktualnyBohater.czy_ma_jednostki() == false) { mapa.UsunBohatera(AktualnyBohater); }
                    if (bohater.czy_ma_jednostki() == false) { mapa.UsunBohatera(bohater); }
                }
            }
        }

        public void ZmienTure()
        {
            AktualnyBohater = null;
            int index = Mapa.Gracze.IndexOf(aktualnyGracz);
            index++;
            if(index == Mapa.Gracze.Count)
            {
                mapa.Dzien++;

                if(Dzien == 1)
                {
                    foreach(Miasto miasto in mapa.Miasta)
                    {
                        miasto.Dodaj_przyrost_jednostki();
                    }
                }
                foreach (Miasto miasto in mapa.Miasta)
                {
                    miasto.Czy_mozna_budowac_tak();
                    miasto.Daj_przychod_dla_wlasciciela();
                }
                foreach (Bohater bohater in mapa.Bohaterowie)
                {
                    bohater.przywroc_caly_ruch_bohaterowi();
                }
                
                index = index % Mapa.Gracze.Count;
            }
            
           
            aktualnyGracz = Mapa.Gracze[index];
        }

        public int Dzien
        {
            get
            {
                return mapa.Dzien % 7 + 1;
            }
        }

        public int Tydzien
        {
            get
            {
                int tygodnie = mapa.Dzien / 7;

                return tygodnie % 4 + 1;
            }
        }
        public int Miesiac
        {
            get
            {
                int tygodnie = mapa.Dzien / 7;
                return tygodnie / 4 + 1;
            }
        }

        public int ZlotoGracza
        {
            get
            {
                return aktualnyGracz.Zloto;
            }
        }

        public string ImieGracza
        {
            get
            {
                return aktualnyGracz.Imie;
            }
        }
        public int IndexGracza
        {
            get
            {
                return Mapa.Gracze.IndexOf(aktualnyGracz);
            }
        }

        public bool AktualnyGracz(Gracz gracz)
        {
            return aktualnyGracz == gracz;
        }
    }
}
