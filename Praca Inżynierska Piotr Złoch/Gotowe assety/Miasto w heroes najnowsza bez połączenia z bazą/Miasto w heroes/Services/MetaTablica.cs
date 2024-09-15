using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
{
    class MetaTablica
    {
        object tablica;
        Type type;
        public MetaTablica(object tablica)
        {
            this.tablica = tablica;
            type = tablica.GetType();
           
            MethodInfo[] methofds = type.GetMethods();
        }

        public int Length
        {
            get
            {
                PropertyInfo wpasciwoscLength = type.GetProperty("Length");
                return (int)wpasciwoscLength.GetValue(tablica);
            }
        }

        public object Tablica
        {
            get
            {
                return tablica;
            }
        }

        public object GetItem(int index)
        {
            MethodInfo GetValue = type.GetMethod("Get");
            object[] parameters = new object[1];
            parameters[0] = index;
            return GetValue.Invoke(tablica, parameters);
        }


        public void SetItem(int index, object item)
        {
            MethodInfo metodaSet = type.GetMethod("Set");
            object[] parameters = new object[2];
            parameters[0] = index;
            parameters[1] = item;
            metodaSet.Invoke(tablica, parameters);
        }

        public Type ElementType
        {
            get
            {
                MethodInfo metodaGet = type.GetMethod("Get");
                ParameterInfo parametr = metodaGet.ReturnParameter;
                return parametr.ParameterType;
            }

        }

        public static bool JestTablica(object element)
        {
            return element.GetType().Name.EndsWith("[]");
        }



    }
}
