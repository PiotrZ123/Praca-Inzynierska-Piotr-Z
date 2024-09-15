using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    class AI
    {

        public static void RuchJednostka(PoleBitwy Mapa, GraczModel.PoziomAi trudnosc)
        {
            if (trudnosc == GraczModel.PoziomAi.Latwy)
            {
                RuchLatwy(Mapa);
            }
            else if (trudnosc == GraczModel.PoziomAi.Normalny)
            {
                RuchNormalny(Mapa);
            }
            else if (trudnosc == GraczModel.PoziomAi.Trudny)
            {
                //uzycie umiejetnosci
                RuchTrudny(Mapa);
            }
            else
            {
                RuchLatwy(Mapa);
            }



        }
        private static void RuchLatwy(PoleBitwy Mapa)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            switch (randomNumber)
            {
                case 0:
                    Mapa.JednostkaIdzieDol();
                    break;
                case 1:
                    Mapa.JednostkaIdzieGora();
                    break;
                case 2:
                    Mapa.JednostkaIdzieLewo();
                    break;
                case 3:
                    Mapa.JednostkaIdziePrawo();
                    break;

                default:
                    break;
            }
        }
        private static void RuchNormalny(PoleBitwy Mapa)
        {
            Mapa.RuchDoNajblizszejJednostki();
        }
        private static void RuchTrudny(PoleBitwy Mapa)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            if (Mapa.CzyMozeUmiejetnoscPrawy == true) 
            {
                BazaUmiejetnosci.UzyjUmiejetnosciPoIndeksie(randomNumber, Mapa.ZwrocListeJednostek(), Mapa.ZwrocAktualnaJednostka().Wlasciciel);
                Mapa.CzyMozeUmiejetnoscPrawy = false;
            }
            Mapa.RuchDoNajblizszejJednostki();
        }
    }
}
