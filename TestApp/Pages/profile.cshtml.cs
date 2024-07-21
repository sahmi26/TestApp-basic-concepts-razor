using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApp.Pages
{
    public class profileModel : PageModel
    {
        public void OnGet()
        {
            ViewData["myName"] = "Ferhat Pasa Bey";
            ViewData["username"] = "ferhat_bey";
            ViewData["myOccupation"] = "Spreading Love";
            ViewData["myAge"] = 100;
            ViewData["currentDate"] = "07/12/24";
        } 
    }
}
