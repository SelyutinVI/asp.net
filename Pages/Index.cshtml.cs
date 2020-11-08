using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication1.Object;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public MyObject obj;

        public IndexModel()
        {
            obj = new MyObject();
        }

        public void OnPost(List<int> MyInt, List<string> MyString)
        {
            Type type = obj.GetType();
            var props = type.GetProperties();
            int i = 0;
            foreach(var p in props)
            {
                if(Type.Equals(p.PropertyType,typeof(int)))
                {
                    p.SetValue(obj, MyInt[i]); i++;
                }
            }
            i = 0;
            foreach (var p in props)
            {
                if (Type.Equals(p.PropertyType, typeof(string)))
                {
                    p.SetValue(obj, MyString[i]); i++;
                }
            }
        }
    }
}
