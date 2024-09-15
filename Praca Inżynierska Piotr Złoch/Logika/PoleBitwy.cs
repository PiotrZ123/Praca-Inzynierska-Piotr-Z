using Praca_Inżynierska_Piotr_Złoch.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    class PoleBitwy
    {
        public bool CzyMozeUmiejetnoscPrawy { get; set; }
        public bool CzyMozeUmiejetnoscLewy { get; set; }
        bool Zakoncona = false;
        int numerPoziomu;
        Bohater lewy_atakujacy;
        Bohater prawy_broniocy;
        Jednostka aktualna_jednostka;
        int aktualna_jednostka_ilosc_ruchu = 5;
        Jednostka[,] jednostki = new Jednostka[2, 10];
        public object[,] miejsce_na_mapie = new object[10, 20];
        RysowanieAnimacji BitwaFormularz;
        int ii = 0;
        int jj = 0;

        public PoleBitwy(Bohater atakujocy, Bohater broniocy, RysowanieAnimacji Bitwa, int numer)
        {
            numerPoziomu = numer;
            lewy_atakujacy = atakujocy;
            prawy_broniocy = broniocy;
            BitwaFormularz = Bitwa;
            CzyMozeUmiejetnoscLewy = true;
            CzyMozeUmiejetnoscPrawy = true;
            przypisywanie_jednostek();
            ruch_jednostek();
        }

        public void przypisywanie_jednostek()
        {
            if (lewy_atakujacy != null && prawy_broniocy != null)
            {
                for (int i = 0; i < jednostki.Length / 2; i++)
                {
                    jednostki[0, i] = lewy_atakujacy.DajJednostke(i);
                    if (jednostki[0, i] != null)
                    {
                        miejsce_na_mapie[i, 0] = jednostki[0, i];
                        jednostki[0, i].ustaw_lokalizacje_jednostki(i, 0);
                    }
                    jednostki[1, i] = prawy_broniocy.DajJednostke(i);
                    if (jednostki[1, i] != null)
                    {
                        miejsce_na_mapie[i, 19] = jednostki[1, i];
                        jednostki[1, i].ustaw_lokalizacje_jednostki(i, 19);
                    }
                }
            }
        }

        public Jednostka ZwrocAktualnaJednostka()
        {
            return aktualna_jednostka;
        }

        public void ruch_jednostek()
        {
            if (lewy_atakujacy != null && prawy_broniocy != null)
            {
                while (ii <= 10)
                {
                    if (ii == 10)
                    {
                        if (ZakonczBitwe()) {break; }
                        ii = 0;
                        jj = 0;
                        CzyMozeUmiejetnoscLewy = true;
                        CzyMozeUmiejetnoscPrawy = true;
                        foreach (var item in jednostki)
                        {
                            if (item != null) item.PrzywrocKontratak();
                        }
                    }
                    if (jj == 0)
                    {
                        if (jednostki[0, ii] != null)
                        {
                            aktualna_jednostka = jednostki[0, ii];
                            aktualna_jednostka_ilosc_ruchu = aktualna_jednostka.Szybkosc;
                            jj = 1;
                            break;
                        }
                        jj = 1;
                    }
                    else if (jj == 1)
                    {
                        if (jednostki[1, ii] != null)
                        {
                            aktualna_jednostka = jednostki[1, ii];
                            aktualna_jednostka_ilosc_ruchu = aktualna_jednostka.Szybkosc;
                            jj = 0;
                            ii++;
                            while (aktualna_jednostka.Wlasciciel.CzyAi == true && ZakonczBitwe() == false)
                            { 
                                AI.RuchJednostka(this,aktualna_jednostka.Wlasciciel.TrudnoscAi);
                                var form = BitwaFormularz as Form;
                                form.Refresh();
                            }
                            break;
                        }
                        ii++;
                        jj = 0;
                    }
                }
            }
        }

        public Jednostka[,] ZwrocListeJednostek()
        {
            return jednostki;
        }
        public int ZwrocIloscRuchu()
        {
            return aktualna_jednostka_ilosc_ruchu;
        }

        public void ZawartoscJednostkaIdzieNa(int x_aktualnej, int y_aktualnej, int x_nastepny, int y_nastepny)
        {
            if (x_nastepny >= 0 && x_nastepny <= 9 && y_nastepny >= 0 && y_nastepny <= 19)
            {
                if (miejsce_na_mapie[x_nastepny, y_nastepny] == null)
                {
                    aktualna_jednostka.ustaw_lokalizacje_jednostki(x_nastepny, y_nastepny);
                    miejsce_na_mapie[x_aktualnej, y_aktualnej] = null;
                    miejsce_na_mapie[x_nastepny, y_nastepny] = aktualna_jednostka;
                    jednostka_wykonala_ruch();
                }
                else
                {
                    kontakt_miedzy_jednostkami(x_nastepny, y_nastepny);
                }

            }
        }

        public Bohater ZwrocBohateraPoWlascicielu(Gracz wlasciciel)
        {
            if (lewy_atakujacy.Wlasciciel == wlasciciel) { return lewy_atakujacy; }
            else { return prawy_broniocy; }
        }

        public void kontakt_miedzy_jednostkami(int x_drugiej_jednostki, int y_drugiej_jednostki)
        {
            {
                Jednostka jednostka = miejsce_na_mapie[x_drugiej_jednostki, y_drugiej_jednostki] as Jednostka;
                if (aktualna_jednostka.Wlasciciel != jednostka.Wlasciciel)//atak
                {
                    Dzwiek.odegraj("SwordHit");
                    aktualna_jednostka_ilosc_ruchu = 0;
                    Bohater BohaterAtakujacy = ZwrocBohateraPoWlascicielu(aktualna_jednostka.Wlasciciel);
                    Bohater BohaterBroniacy = ZwrocBohateraPoWlascicielu(jednostka.Wlasciciel);
                    aktualna_jednostka.atak_jednostki(jednostka, BohaterAtakujacy.Atak, BohaterBroniacy.Obrona);
                    BitwaFormularz.WykonajAnimacjeAtakuJednostki(aktualna_jednostka);
                    SmiercZaatakowanejJednostki(jednostka,x_drugiej_jednostki,y_drugiej_jednostki);
                    Kontratak(jednostka,BohaterBroniacy,BohaterAtakujacy);

                    ruch_jednostek();

                }
            }
        }

        private void SmiercZaatakowanejJednostki(Jednostka jednostka,int x_drugiej_jednostki, int y_drugiej_jednostki)
        {
            if (jednostka.Ilosc <= 0)//smierc zaatakowanej jednostki
            {
                miejsce_na_mapie[x_drugiej_jednostki, y_drugiej_jednostki] = null;
                for (int i = 0; i < jednostki.GetLength(0); i++)
                {
                    for (int j = 0; j < jednostki.GetLength(1); j++)
                    {
                        if (jednostki[i, j] == jednostka)
                        {
                            BitwaFormularz.WykonajAnimacjeSmierciJednostki(jednostki[i, j]);
                            jednostki[i, j] = null;
                            if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                            else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                            Dzwiek.odegraj("Death");
                            break;
                        }
                    }
                }
            }
        }

        private void Kontratak(Jednostka jednostka,Bohater BohaterBroniacy, Bohater BohaterAtakujacy)
        {
            if (jednostka.Ilosc > 0 && jednostka.Kontratak > 0)//kontratak
            {
                Dzwiek.odegraj("SwordHit");
                jednostka.Kontratak--;
                jednostka.atak_jednostki(aktualna_jednostka, BohaterBroniacy.Atak, BohaterAtakujacy.Obrona);
                BitwaFormularz.WykonajAnimacjeAtakuJednostki(jednostka);
                SmniercAktualnejJednostki();
            }
        }

        public bool ZakonczBitwe()
        {
            if (lewy_atakujacy.czy_ma_jednostki() == false || prawy_broniocy.czy_ma_jednostki() == false)
            {
                if (Zakoncona == false)
                {
                    if (prawy_broniocy.czy_ma_jednostki() == false)
                    {
                        if (numerPoziomu > Config.Odczytaj("Poziom"))
                        {
                            Config.Zapisz(numerPoziomu, "Poziom");
                        }
                        Dzwiek.odegraj("Victory");
                        WygranaPrzegrana opcje = new WygranaPrzegrana(true);
                        opcje.ShowDialog();
                    }
                    if (lewy_atakujacy.czy_ma_jednostki() == false)
                    {
                        Dzwiek.odegraj("Defeat");
                        WygranaPrzegrana opcje = new WygranaPrzegrana(false);
                        opcje.ShowDialog();
                    }
                    Zakoncona = true;
                }
                var formularz = (Bitwa)BitwaFormularz;
                formularz.Close();
                return true;
            }
            return false;
        }

        private void SmniercAktualnejJednostki()
        {
            if (aktualna_jednostka.Ilosc <= 0)//smierc aktualnej jednostki
            {
                miejsce_na_mapie[aktualna_jednostka.X, aktualna_jednostka.Y] = null;
                for (int i = 0; i < jednostki.GetLength(0); i++)
                {
                    for (int j = 0; j < jednostki.GetLength(1); j++)
                    {
                        if (jednostki[i, j] == aktualna_jednostka)
                        {
                            BitwaFormularz.WykonajAnimacjeSmierciJednostki(jednostki[i, j]);
                            jednostki[i, j] = null;
                            if (i == 0) { lewy_atakujacy.dodaj_jednostke(null, j); }
                            else if (i == 1) { prawy_broniocy.dodaj_jednostke(null, j); }
                            Dzwiek.odegraj("Death");
                            break;
                        }
                    }
                }
            }
        }

        public void jednostka_wykonala_ruch()
        {
            aktualna_jednostka_ilosc_ruchu--;
            if (aktualna_jednostka_ilosc_ruchu <= 0)
            {
                ruch_jednostek();
            }

        }

        private bool CzyMozeDzialac()
        {
            if (aktualna_jednostka.Y > 0 && (miejsce_na_mapie[aktualna_jednostka.X, aktualna_jednostka.Y - 1] == null || miejsce_na_mapie[aktualna_jednostka.X, aktualna_jednostka.Y - 1] == null))
            {
                return true;
            }

            // Sprawdzanie, czy jednostka może poruszyć się w dół
            if (aktualna_jednostka.Y < 19 && (miejsce_na_mapie[aktualna_jednostka.X, aktualna_jednostka.Y + 1] == null || miejsce_na_mapie[aktualna_jednostka.X, aktualna_jednostka.Y + 1] == null))
            {
                return true;
            }

            // Sprawdzanie, czy jednostka może poruszyć się w prawo
            if (aktualna_jednostka.X < 9 && (miejsce_na_mapie[aktualna_jednostka.X + 1, aktualna_jednostka.Y] == null || miejsce_na_mapie[aktualna_jednostka.X + 1, aktualna_jednostka.Y] == null))
            {
                return true;
            }

            // Sprawdzanie, czy jednostka może poruszyć się w lewo
            if (aktualna_jednostka.X > 0 && (miejsce_na_mapie[aktualna_jednostka.X - 1, aktualna_jednostka.Y] == null || miejsce_na_mapie[aktualna_jednostka.X - 1, aktualna_jednostka.Y] == null))
            {
                return true;
            }
            return false;
        }

        public void WykonajRuchLista(List<Point> lista)
        {
            if (lista != null&& lista.Count != 0 )
            {
                Point aktualny = new Point(aktualna_jednostka.X, aktualna_jednostka.Y);
                Jednostka jednostka = aktualna_jednostka;

                foreach (var item in lista)
                {
                    if (jednostka == aktualna_jednostka)
                    {
                        if (aktualny.X > item.X && aktualny.Y == item.Y) { JednostkaIdzieGora(); }
                        else if (aktualny.X < item.X && aktualny.Y == item.Y) { JednostkaIdzieDol(); }
                        else if (aktualny.X == item.X && aktualny.Y > item.Y) { JednostkaIdzieLewo(); }
                        else if (aktualny.X == item.X && aktualny.Y < item.Y) { JednostkaIdziePrawo(); }
                        else if (aktualny.X > item.X && aktualny.Y < item.Y) { JednostkaIdzieGoraPrawo(); }
                        else if (aktualny.X > item.X && aktualny.Y > item.Y) { JednostkaIdzieGoraLewo(); }
                        else if (aktualny.X < item.X && aktualny.Y < item.Y) { JednostkaIdziedolPrawo(); }
                        else if (aktualny.X < item.X && aktualny.Y > item.Y) { JednostkaIdzieDolLewo(); }
                        aktualny = item;
                    }
                }
            }
            else if (aktualna_jednostka.Wlasciciel.CzyAi == true && lista == null || lista.Count == 0 && aktualna_jednostka.Wlasciciel.CzyAi == true) { ruch_jednostek(); }
        }

        public void RuchDoNajblizszejJednostki()
        {
            List<Point> lista = new List<Point>();
            foreach (var item in jednostki)
            {
                if (item!= null && aktualna_jednostka.Wlasciciel != item.Wlasciciel)
                {
                    List<Point> ListaTymczasowa = ZnajdywanieDrogi.ZwrocNajkrotszaDroga(miejsce_na_mapie, aktualna_jednostka.X, aktualna_jednostka.Y, item.X, item.Y);
                    if (ListaTymczasowa!= null && lista.Count == 0 && ListaTymczasowa.Count > 0) { lista = ListaTymczasowa; }
                    if (ListaTymczasowa != null && ListaTymczasowa.Count <= lista.Count)
                    {
                        lista = ListaTymczasowa;
                    }
                }
            }
            WykonajRuchLista(lista);
        }

        private void RefreshBitwy()
        {
            var Bitwa = BitwaFormularz as Bitwa;
            Bitwa.Refresh();
        }

        public void JednostkaIdzieGora()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x - 1, y);
            RefreshBitwy();
        }

        public void JednostkaIdzieDol()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x + 1, y);
            RefreshBitwy();
        }

        public void JednostkaIdzieLewo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x, y - 1);
            RefreshBitwy();
        }

        public void JednostkaIdziePrawo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x, y + 1);
            RefreshBitwy();
        }

        public void JednostkaIdzieGoraPrawo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x - 1, y + 1);
            RefreshBitwy();
        }

        public void JednostkaIdzieGoraLewo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x - 1, y - 1);
            RefreshBitwy();
        }

        public void JednostkaIdziedolPrawo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x + 1, y + 1);
            RefreshBitwy();
        }

        public void JednostkaIdzieDolLewo()
        {
            int x = aktualna_jednostka.X;
            int y = aktualna_jednostka.Y;
            ZawartoscJednostkaIdzieNa(x, y, x + 1, y - 1);
            RefreshBitwy();
        }
    }
}
