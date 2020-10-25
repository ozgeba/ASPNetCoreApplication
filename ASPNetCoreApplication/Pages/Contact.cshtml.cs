using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreApplication.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
            string x= ApiCall.GetValueById(555);
            Message += x;
        }
    }
}
