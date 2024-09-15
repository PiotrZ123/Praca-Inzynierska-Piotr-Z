using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Model
{
    public interface ObiektNaMapie
    {
        void AkcjaPoKliknieciu(Gra gra);
        void Interakcja(Bohater bohater);
        void Rysuj(Graphics grafika);
    }
}
