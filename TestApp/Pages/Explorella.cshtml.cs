using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestApp.Pages
{
    public class ExplorellaModel : PageModel
    {
        public string Country { get; set; }
        public List<SelectListItem> Countries { get; set; }
        public void OnGet()
        {
            Countries = new List<SelectListItem>()
            {
            new SelectListItem { Value = "AR", Text = "Argentina" },
            new SelectListItem { Value = "FR", Text = "France" },
            new SelectListItem { Value = "KE", Text = "Kenya" },
            new SelectListItem { Value = "BR", Text = "Brazil" },
            new SelectListItem { Value = "GER", Text = "Germany" },
            new SelectListItem { Value = "CHI", Text = "China" },
            };
        }
    }
}
