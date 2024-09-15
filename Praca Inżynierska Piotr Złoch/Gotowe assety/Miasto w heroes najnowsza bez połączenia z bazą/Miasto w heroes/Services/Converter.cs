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
    public class Converter
    {
        List<string> info;

        public MapaModel Convert(Mapa mapa)
        {
            info = new List<string>();
            MapaModel mapaModel = new MapaModel();
            KopiujWlasciwosci(mapaModel, mapa);
         //   int len = info.Count;
            return mapaModel;
        }

        public Mapa Convert(MapaModel mapaModel)
        {
            info = new List<string>();
            Mapa mapa = new Mapa();
            KopiujWlasciwosci(mapa, mapaModel);
           // int len = info.Count;
            return mapa;
        }

        private void KopiujWlasciwosci(object obiektDocelowy, object obiektZrodlowy)
        {
        Type typZrodlowy = obiektZrodlowy.GetType();
            Type typDocelowy = obiektDocelowy.GetType();
            PropertyInfo[] wlasciwosciZrodlowe = typZrodlowy.GetProperties();

            for(int i=0; i<wlasciwosciZrodlowe.Length; i++)
            {
                PropertyInfo wlasciwoscDocelowa = typDocelowy.GetProperty(wlasciwosciZrodlowe[i].Name);
                if(wlasciwoscDocelowa==null)
                {
                    info.Add(string.Format("w selemencie:[{0}] wlasciwosc [{1}] nie ma pokrucia", typDocelowy.FullName, wlasciwosciZrodlowe[i].Name));
                }

                if(wlasciwoscDocelowa!=null)
                {
                    object elementZrodlowy = wlasciwosciZrodlowe[i].GetValue(obiektZrodlowy);
                    if (elementZrodlowy != null)
                    {
                        if (MetaLista.JestLista(elementZrodlowy) || MetaTablica.JestTablica(elementZrodlowy))
                        {
                            object kolekcjaDocelowa = wlasciwoscDocelowa.GetValue(obiektDocelowy);
                            if (kolekcjaDocelowa != null)
                            {
                                if (MetaLista.JestLista(kolekcjaDocelowa) && MetaLista.JestLista(elementZrodlowy))
                                {
                                    KopiujListe(new MetaLista(kolekcjaDocelowa), new MetaLista(elementZrodlowy));
                                }
                                else if (MetaTablica.JestTablica(kolekcjaDocelowa) && MetaLista.JestLista(elementZrodlowy))
                                {
                                    KopiujTablice(new MetaTablica(kolekcjaDocelowa), new MetaLista(elementZrodlowy));
                                }
                                else if (MetaLista.JestLista(kolekcjaDocelowa) && MetaTablica.JestTablica(elementZrodlowy))
                                {
                                    KopiujTablice(new MetaLista(kolekcjaDocelowa), new MetaTablica(elementZrodlowy));
                                }
                            }
                        }
                        else if (elementZrodlowy.GetType().FullName == wlasciwoscDocelowa.PropertyType.FullName)
                        {
                            //string element1 = elementZrodlowy.GetType().FullName;
                            //string element2 = wlasciwoscDocelowa.PropertyType.FullName;
                            wlasciwoscDocelowa.SetValue(obiektDocelowy, elementZrodlowy);
                        }
                        else
                        {
                            object elementDecelowy = KopiujObiekty(wlasciwoscDocelowa.PropertyType, elementZrodlowy);
                            wlasciwoscDocelowa.SetValue(obiektDocelowy, elementDecelowy);
                        }
                    }
                }
            }
        }

        private object KopiujObiekty(Type typDocelowy, object source)
        {
            if(source==null)
            {
                return null;
            }

            object target = typDocelowy.Assembly.CreateInstance(typDocelowy.FullName);
            KopiujWlasciwosci(target, source);
            return target;
        }

        private void KopiujTablice(MetaLista listaDocelowa, MetaTablica tablicaZrodlowa)
        {
            for (int i = 0; i < tablicaZrodlowa.Length; i++)
            {
                object elementZrodlowy = tablicaZrodlowa.GetItem(i);
                if (elementZrodlowy != null)
                {
                    object elementDocelowy = KopiujObiekty(listaDocelowa.ElementType, elementZrodlowy);
                    PropertyInfo polorzenieWTablicyProperty = elementDocelowy.GetType().GetProperty("PolozenieWTablicy");
                    polorzenieWTablicyProperty.SetValue(elementDocelowy, i);
                    listaDocelowa.Add(elementDocelowy);
                }
            }
        }
        private void KopiujTablice(MetaTablica tablicaDocelowa, MetaLista listaZrodlowa)
        {
            for (int i = 0; i < listaZrodlowa.Count; i++)
            {
                object elementZrodlowy = listaZrodlowa.GetItem(i);
                if (elementZrodlowy != null)
                {
                    object elementDocelowy = KopiujObiekty(tablicaDocelowa.ElementType, elementZrodlowy);
                    PropertyInfo polorzenieWTablicyProperty = elementZrodlowy.GetType().GetProperty("PolozenieWTablicy");
                    int index = (int)polorzenieWTablicyProperty.GetValue(elementZrodlowy);
                    
                    tablicaDocelowa.SetItem(index, elementDocelowy);
                }
            }
        }

       /* private void KopiujTablice(MetaTablica tablicaDocelowa, MetaTablica tablicaZrodlowa)
        {
            for (int i = 0; i < tablicaZrodlowa.Length; i++)
            {
                object elementZrodlowy = tablicaZrodlowa.GetItem(i);
                object elementDocelowy = KopiujObiekty(tablicaDocelowa.ElementType, elementZrodlowy);
                tablicaDocelowa.SetItem(i, elementDocelowy);
            }
        }*/
        private void KopiujListe(MetaLista listaDocelowa, MetaLista listaZrodlowa)
        {
            for(int i=0; i< listaZrodlowa.Count; i++)
            {
                object elementZrodlowy = listaZrodlowa.GetItem(i);
                if(elementZrodlowy!=null)
                {
                    object elementDocelowy = KopiujObiekty(listaDocelowa.ElementType, elementZrodlowy);
                    listaDocelowa.Add(elementDocelowy);
                }
                
            }
        }

        

        
}
}
