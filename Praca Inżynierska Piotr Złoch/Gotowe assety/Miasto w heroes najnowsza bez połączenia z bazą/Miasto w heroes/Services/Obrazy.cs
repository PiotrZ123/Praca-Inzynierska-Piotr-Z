using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
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

        public static Image GetTarcza()
        {
            return Image.FromFile(@"..\..\grafika\tarcza.jpg");
        }

        


    }
}
