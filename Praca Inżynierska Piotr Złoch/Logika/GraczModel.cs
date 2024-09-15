using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public class GraczModel
    {
        public enum PoziomAi
        {
            Latwy,
            Normalny,
            Trudny
        }
        public bool CzyAi = false;

        public PoziomAi TrudnoscAi = PoziomAi.Latwy;
        public string NumerGuid { get; set; }

        public string Imie { get; set; }
        public string Kolor { get; set; }
        public int Zloto { get; set; }
    }
}
