using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    class Obrazy
    {
       
        public static Image GetMiasto(string kolor)
        {
            return Image.FromFile(@"..\..\grafika\zamek_" + kolor + ".png");
        }
        public static Image GetBohater(string kolor)
        {
            return Image.FromFile(@"..\..\grafika\Bohater_" + kolor + ".png");
        }

        public static Image GetBohaterPortret(string name)
        {
            try
            {
                return Image.FromFile(@"..\..\grafika\bohaterowie\Bohater_" + name + ".png");
            }
            catch (Exception)
            {
                return Image.FromFile(@"..\..\grafika\bohaterowie\pusty.jpg");
            }
        }

        public static Image GetJednostkaPortret(string name)
        {
            try
            {
                return Image.FromFile(@"..\..\grafika\" + name + ".png");
            }
            catch (Exception)
            {
                return Image.FromFile(@"..\..\grafika\puste.png");
            }
        }

        public static Image GetTarcza()
        {
            return Image.FromFile(@"..\..\grafika\tarcza.jpg");
        }

        public static Image GetStrzalka()
        {
            try
            {
                return Image.FromFile(@"..\..\grafika\Strzalka.png");
            }
            catch (Exception)
            {
                return Image.FromFile(@"..\..\grafika\puste.png");
            }
        }


    }
}
