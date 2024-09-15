using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public static class BazaUmiejetnosci
    {
        public static void UzyjUmiejetnosciPoIndeksie(int index, Jednostka[,] lista, Gracz Wlasciciel)
        {
            switch (index)
            {
                case 0: Umiejetnosci.Uzycie(lista, "Atak", 2,Wlasciciel);
                    break;
                case 1:
                    Umiejetnosci.Uzycie(lista, "Obrona", 2, Wlasciciel);
                    break;
                case 2:
                    Umiejetnosci.Uzycie(lista, "Zycie_max", 1, Wlasciciel);
                    break;
                case 3:
                    Umiejetnosci.Uzycie(lista, "Szybkosc", 2, Wlasciciel);
                    break;
                default:
                    break;
            }
        }
    }
}
