using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public static class Config//klasa do zmiany jesli w opcjach będą dodatkowe opcje
    {
        public static double Odczytaj(string nazwaPliku)
        {
            try
            {
                string parentFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string plik = Path.Combine(parentFolder, nazwaPliku);
                string zawartoscPliku = File.ReadAllText(plik);
                double szybkosc = double.Parse(zawartoscPliku);
                return szybkosc;
            }
            catch (Exception)
            {
                Zapisz(1, nazwaPliku);
                return 1;
            }
        }
        public static void Zapisz(double wartosc, string nazwaPliku)
        {
            string parentFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string plik = Path.Combine(parentFolder, nazwaPliku);
            string dokument = $"{wartosc}";
            File.WriteAllText(plik, dokument);
        }
    }
}
