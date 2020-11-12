using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using WebApplication1.Object;

namespace WebApplication1.Interface
{
    public interface MyInterface
    {
        public void SetTypes(List<Type> types);
        public Dictionary<Type, Dictionary<PropertyInfo,string>> MyGetProperties(object a);
        public void MySetProperties(object a, Dictionary<Type, Dictionary<PropertyInfo, string>> values);
    }
}
