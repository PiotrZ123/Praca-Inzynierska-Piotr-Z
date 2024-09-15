using ModelDanych;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarstwaDostępuDoDanych
{
    public class BazaDanych
    {
        public void Zapisz(MapaModel model)
        {
            DatabaseContext databaseContext = new DatabaseContext();

            model.DataICzasUtorzenia = DateTime.Now;

            databaseContext.Mapy.Add(model);
            if (model.Id != 0)
            {
                databaseContext.Entry(model).State = System.Data.Entity.EntityState.Modified;
            }
            databaseContext.SaveChanges();

        }
        public MapaModel Wczytaj(int id)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            MapaModel mapa = databaseContext.Mapy.Find(id);

            databaseContext.Entry(mapa).Collection(x => x.Bohaterowie).Load();
            foreach(BohaterModel bohater in mapa.Bohaterowie)
            {
                databaseContext.Entry(bohater).Collection(x => x.Jednostki).Load();
            }
            databaseContext.Entry(mapa).Collection(x => x.Miasta).Load();
            foreach (MiastoModel miasto in mapa.Miasta)
            {
                databaseContext.Entry(miasto).Reference(x => x.BohaterWMiescie).Load();
                databaseContext.Entry(miasto).Collection(x => x.Budynki).Load();
                //databaseContext.Entry(miasto).Collection(x => x.JednostkaDoRekrutacji).Load();
            }

            databaseContext.Entry(mapa).Collection(x => x.Gracze).Load();
         
            return mapa;
        }

        public void Usun(int id)
        {
            DatabaseContext databaseContext = new DatabaseContext();
            MapaModel mapa = databaseContext.Mapy.Find(id);

            databaseContext.Entry(mapa).Collection(x => x.Bohaterowie).Load();
            
            while (mapa.Bohaterowie.Count>0)
            {
                BohaterModel bohater = mapa.Bohaterowie[0];
                databaseContext.Entry(bohater).Collection(x => x.Jednostki).Load();
                while (bohater.Jednostki.Count > 0)
                {

                    databaseContext.Jednostki.Attach(bohater.Jednostki[0]);
                    databaseContext.Jednostki.Remove(bohater.Jednostki[0]);
                    databaseContext.SaveChanges();
                }

                databaseContext.Bohaterowie.Attach(bohater);
                databaseContext.Bohaterowie.Remove(bohater);
                databaseContext.SaveChanges();
            }

            databaseContext.Entry(mapa).Collection(x => x.Miasta).Load();
            while (mapa.Miasta.Count > 0)
            {
                MiastoModel miasto = mapa.Miasta[0];
                databaseContext.Entry(miasto).Reference(x => x.BohaterWMiescie).Load();

                databaseContext.Bohaterowie.Attach(miasto.BohaterWMiescie);
                databaseContext.Bohaterowie.Remove(miasto.BohaterWMiescie);
                databaseContext.SaveChanges();

                databaseContext.Entry(miasto).Collection(x => x.Budynki).Load();
                while (miasto.Budynki.Count > 0)
                {

                    databaseContext.Budynki.Attach(miasto.Budynki[0]);
                    databaseContext.Budynki.Remove(miasto.Budynki[0]);
                    databaseContext.SaveChanges();
                }


                databaseContext.Miasta.Attach(miasto);
                databaseContext.Miasta.Remove(miasto);
                databaseContext.SaveChanges();
            }

            databaseContext.Entry(mapa).Collection(x => x.Gracze).Load();
            while (mapa.Gracze.Count > 0)
            {
                GraczModel gracz = mapa.Gracze[0];
                databaseContext.Gracze.Attach(gracz);
                databaseContext.Gracze.Remove(gracz);
                databaseContext.SaveChanges();
            }

            databaseContext.Mapy.Attach(mapa);
            databaseContext.Mapy.Remove(mapa);
            databaseContext.SaveChanges();

        }
      
        public List<MapaModel> WczytajMapy()
        {
            DatabaseContext databaseContext = new DatabaseContext();
            return databaseContext.Mapy.ToList<MapaModel>();
        }

      
      

    }
}
