using Miasto_w_heroes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes
{
    class ListaGraca<T> where T:ObiektWlasciciela
    {
        List<T> lista;

        public ListaGraca(List<T> lista)
        {
            this.lista = lista;
        }

        public List<T> DajListeDlaGracza(Gracz gracz)
        {
            List<T> listaDlaGracza = new List<T>();
            foreach (T element in lista)
            {
                if(element.Wlasciciel == gracz)
                {
                    listaDlaGracza.Add(element);
                }
            }
            return listaDlaGracza;
        }
    }
}
