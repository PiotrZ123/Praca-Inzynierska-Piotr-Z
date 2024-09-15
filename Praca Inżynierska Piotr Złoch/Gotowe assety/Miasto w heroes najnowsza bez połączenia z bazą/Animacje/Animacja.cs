using ConfigRozwiazanie;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animacje
{
    public class Animacja
    {
        public int CalkowaitaIloscKlatek { get; set; }
        public string NazwaFolderu { get; set; }
        int AktualnyNumerObrazu { get; set; }
        bool CzyAnimacjaZapetlonaDziala { get; set; }
        bool CzyAnimacjaDziala { get; set; }
        //public List<Image> myList = new List<Image>();

        public Animacja(int NumerJednostki, int TypAnimacji)
        {
            NazwaFolderu = ZwrocNazweFolderuPoNumerze(NumerJednostki)+ZwrocTypAnimacjiPoNumerze(TypAnimacji);
            SprawdzCalkowitaIloscKlatek();
            AktualnyNumerObrazu = 0;
            CzyAnimacjaDziala = false;
            CzyAnimacjaZapetlonaDziala = false;

        }

        private string ZwrocNazweFolderuPoNumerze(int numer)
        {
            if (numer >= 0 && numer <= 3) { return "j1_1"; }//ustaw przyrost jednostkom 1 poziomu
            if (numer >= 4 && numer <= 7) { return "j2_1"; }//ustaw przyrost jednostkom 2 poziomu
            if (numer >= 8 && numer <= 11) { return "j3_1"; }//ustaw przyrost jednostkom 3 poziomu
            if (numer >= 12 && numer <= 15) { return "j4_1"; }//ustaw przyrost jednostkom 4 poziomu
            if (numer >= 16 && numer <= 19) { return "j5_1"; }//ustaw przyrost jednostkom 5 poziomu
            return null;
        }

        private string ZwrocTypAnimacjiPoNumerze(int numer)
        {
            if (numer == 0) { return "_atak"; }
            if (numer == 1) { return "_smierc"; }
            return "";
        }

        private void SprawdzCalkowitaIloscKlatek()
        {
            CalkowaitaIloscKlatek = -1;
            int i = 0;
            Image image;
            while (i < 128 && i != CalkowaitaIloscKlatek)
                try
                {
                    image = Image.FromFile($@"..\..\Animacja\{NazwaFolderu}\" + i + ".png");
                    i++;
                }
                catch (Exception)
                {
                    CalkowaitaIloscKlatek = i;
                }
        }

        public List<Image> ZbierzObrazyDoListy()
        {
            List<Image> myList = new List<Image>();
            AktualnyNumerObrazu = 0;
            while (AktualnyNumerObrazu <= CalkowaitaIloscKlatek)
            {
                myList.Add(PobierzObrazZFolderu());
                AktualnyNumerObrazu++;
            }
            return myList;
        }


        public Image PobierzObrazZFolderu()
        {
            try
            {
                return Image.FromFile($@"..\..\Animacja\{NazwaFolderu}\" + AktualnyNumerObrazu + ".png");
            }
            catch (Exception)
            {
                return Image.FromFile(@"..\..\Animacja\A0.png");
            }
        }

        public async Task RysujCiagleAsync(Graphics grafika, int x, int y)
        {
            if (CzyAnimacjaZapetlonaDziala == false)
            {
                CzyAnimacjaZapetlonaDziala = true;
                await RysujAsync2(grafika, x, y);
            }
        }

        private void RysujRazZawartosc(Graphics grafika, int x, int y)
        {
            while (AktualnyNumerObrazu < CalkowaitaIloscKlatek)
            {
                grafika.DrawImage(PobierzObrazZFolderu(), x * 50, y * 50, 50, 50);
                AktualnyNumerObrazu++;
                double SzybkoscAnimacji = Config.Odczytaj();
                Thread.Sleep((int)(2000 /CalkowaitaIloscKlatek/SzybkoscAnimacji));
            }
        }

        public void RysujRaz(Graphics grafika, int x, int y)
        {
            if (CzyAnimacjaDziala == false)
            {
                CzyAnimacjaDziala = true;
                RysujRazZawartosc(grafika, x, y);
                AktualnyNumerObrazu = 0;
                CzyAnimacjaDziala = false;
            }
        }
        private async Task RysujAsync2(Graphics grafika, int x, int y)
        {
            while (AktualnyNumerObrazu <= CalkowaitaIloscKlatek)
            {
                grafika.DrawImage(PobierzObrazZFolderu(), x * 50, y * 50, 50, 50);
                AktualnyNumerObrazu++;
                await Task.Delay(500);
                if (AktualnyNumerObrazu == CalkowaitaIloscKlatek) { AktualnyNumerObrazu = 0; }
            }
        }
    }


}

