using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
{
    class MetaLista
    {
        object list;
        Type type;
        public MetaLista(object list)
        {
            this.list = list;
            type = list.GetType();
        }

        public int Count
        {
            get
            {
                MethodInfo countMethos = type.GetMethod("get_Count");
                object[] parameters = new object[0];
                return (int)countMethos.Invoke(list, parameters);
            }
        }

        public object Lista
        {
            get
            {
                return list;
            }
        }


        public object GetItem(int index)
        {
            MethodInfo get_Item = type.GetMethod("get_Item");
            object[] parameters = new object[1];
            parameters[0] = index;
            return get_Item.Invoke(list, parameters);
        }
        public void Add(object item)
        {
            MethodInfo metodaAdd = type.GetMethod("Add");
            object[] parameters = new object[1];
            parameters[0] = item;
            metodaAdd.Invoke(list, parameters);
        }

        public Type ElementType
        {
            get
            {
                MethodInfo metodaAdd = type.GetMethod("Add");
                ParameterInfo[] paramery = metodaAdd.GetParameters();
                ParameterInfo parametr = paramery[0];
                return parametr.ParameterType;
            }
            
        }

        public static bool JestLista(object element)
        {
            return element.GetType().Name.StartsWith("List");
        }
        
    }
}
