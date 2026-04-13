using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    internal static class Tools
    {

        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type type = t.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                str += string.Format(property.Name, property.GetValue(t));
            }
            return str;
        }
    }
}
