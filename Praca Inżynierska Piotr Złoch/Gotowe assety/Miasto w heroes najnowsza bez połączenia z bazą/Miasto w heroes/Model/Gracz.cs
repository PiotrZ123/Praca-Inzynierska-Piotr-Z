using ModelDanych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    public class Gracz : GraczModel
    {
        public int Id { get; set; }

        public Gracz()
        {
            Zloto = 100000;
            Imie = "";
            Kolor = "";
            NumerGuid = Guid.NewGuid().ToString();
        }

        public Gracz(string imie, string kolor)
        {
            Zloto = 100000;
            Imie = imie;
            Kolor = kolor;
            NumerGuid = Guid.NewGuid().ToString();
        }
        public Gracz(string imie, string kolor, int zloto)
        {
            Imie = imie;
            Kolor = kolor;
            Zloto = zloto;
            NumerGuid = Guid.NewGuid().ToString();
        }
       
    }
}
