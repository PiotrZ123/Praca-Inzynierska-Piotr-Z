using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigRozwiazanie
{
    public static class Config//klasa do zmiany jesli w opcjach będą dodatkowe opcje
    {
        public static double Odczytaj()
        {
            try
            {
                string parentFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string plik = Path.Combine(parentFolder, "Config");
                string zawartoscPliku = File.ReadAllText(plik);
                double szybkosc = double.Parse(zawartoscPliku);
                return szybkosc;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public static void Zapisz(double szybkosc)
        {
            string parentFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string plik = Path.Combine(parentFolder, "Config");
            string dokument = $"{szybkosc}";
            File.WriteAllText(plik, dokument);
        }
    }
}
