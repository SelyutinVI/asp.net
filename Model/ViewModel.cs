using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class ViewModel
    {
        public string Name { get; set; }
        public Dictionary<Type, Dictionary<PropertyInfo,string>> Properties{ get; set; }
    }
}
