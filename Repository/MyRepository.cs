using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using WebApplication1.Interface;

namespace WebApplication1.Repository
{
    public class MyRepository : MyInterface
    {
        private List<Type> types;
        public MyRepository()
        {
            types = new List<Type>();           
        }

        private Dictionary<PropertyInfo, string> getProp(object obj, Type t)
        {
            var type = obj.GetType();
            PropertyInfo[] prop = type.GetProperties();
            Dictionary<PropertyInfo,string> _values = new Dictionary<PropertyInfo, string>();
            foreach (PropertyInfo e in prop)
            {
                if (Type.Equals(e.PropertyType, t))
                {
                    _values.Add(e, e.GetValue(obj).ToString());
                }
            }
            return _values;
        } //Функция получения свойств по типу

        public void SetTypes(List<Type> types) {
            this.types = types;
        } //Установка типов свойств

        public Dictionary<Type, Dictionary<PropertyInfo,string>> MyGetProperties(object obj)
        {
            Dictionary<Type, Dictionary<PropertyInfo,string>> result = new Dictionary<Type, Dictionary<PropertyInfo, string>>();
            foreach(Type t in types)
            result.Add(t, getProp(obj,t));
            return result;
        } //Получение свойств объекта

        public void MySetProperties(object a, Dictionary<Type, Dictionary<PropertyInfo, string>> values)
        {
            foreach (var t in values)
                foreach (var p in t.Value)
                {
                    try
                    {
                        p.Key.SetValue(a, Convert.ChangeType(p.Value, t.Key));
                    }
                    catch
                    {

                    }

                }
        } //Установка значений свойств
    }
}
