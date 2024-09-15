using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    class PrzeszkodaMiasto : ObiektNaMapie
    {
        private Miasto miasto;
        public PrzeszkodaMiasto(Miasto miasto)
        {
            this.miasto = miasto;
        }
        public void AkcjaPoKliknieciu(Gra gra)
        {
            miasto.AkcjaPoKliknieciu(gra);
        }

        public void Interakcja(Bohater bohater)
        {
        }

        public void Rysuj(Graphics grafika)
        {
        }
    }
}
