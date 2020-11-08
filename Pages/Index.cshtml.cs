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

        public void OnGet(MyObject obj)
        {
            obj = this.obj;
        }
    }
}
