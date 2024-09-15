using Miasto_w_heroes.Model;
using ModelDanych;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
{
    public class Logic
    {
        private static Logic instancja;

        private Logic()
        {

        }

        public static Logic DajInstancje()
        {
            if(instancja==null)
            {
                instancja = new Logic();
            }
            return instancja;
        }

        public void SaveMap(Mapa mapa)
        {

        }
        public MapaModel Convert(Mapa mapa)
        {
            Converter c = new Converter();
            return c.Convert(mapa);

        }
        public Mapa Convert(MapaModel mapaModel)
        {
            Converter c = new Converter();
            return c.Convert(mapaModel);
        }


    }
}
