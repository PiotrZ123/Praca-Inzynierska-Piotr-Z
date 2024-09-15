using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public static class Umiejetnosci
    {
        private static void DodajDoPolaJednostki(string nazwaPola, int wartosc, Jednostka jednostka)
        {
            Type klasa1Type = typeof(JednostkaModel);
            FieldInfo poleInfo = klasa1Type.GetField(nazwaPola,BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetField);
            if (poleInfo == null)
            {
                poleInfo = klasa1Type.GetField("<" + nazwaPola + ">k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetField);
            }

            if (poleInfo != null && poleInfo.FieldType == typeof(int))
            {
                int aktualnaWartosc = (int)poleInfo.GetValue(jednostka);
                poleInfo.SetValue(jednostka, aktualnaWartosc + wartosc);
            }
            else
            {
                Console.WriteLine("Błąd: Nie znaleziono pola o nazwie {0} lub nie jest to pole typu int.", nazwaPola);
            }
        }

        static public void Uzycie(Jednostka[,] lista, string NazwaAtrybutu, int WartoscZmiany, Gracz Wlasciciel)
        {
            foreach (var item in lista)
            {
                if (item!=null &&Wlasciciel == item.Wlasciciel)
                {
                    DodajDoPolaJednostki(NazwaAtrybutu, WartoscZmiany, item);
                }
            }
        }
    }
}
