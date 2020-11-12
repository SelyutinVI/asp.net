using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.Object;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private MyInterface _interface;
        private MyObject _obj;
        public ViewModel vm;

        public IndexModel(MyInterface _i)
        {
            _interface = _i;
            List<Type> types = new List<Type> { typeof(int), typeof(string) }; //определение типов свойств
            _i.SetTypes(types);

            _obj = new MyObject();            
            vm = new ViewModel();
            vm.Name = _obj.GetType().Name;
            vm.Properties = _interface.MyGetProperties(_obj);
        }

        public void OnPost(Dictionary<string,string> properties)
        {
            foreach (var p in properties)
                foreach (var t in vm.Properties)
                    foreach (var i in t.Value.ToList())
                        if (p.Key == i.Key.Name)
                            vm.Properties[t.Key][i.Key] = p.Value;
            _interface.MySetProperties(_obj, vm.Properties);
            vm.Name = _obj.GetType().Name;
            vm.Properties = _interface.MyGetProperties(_obj);
        }
    }
}
