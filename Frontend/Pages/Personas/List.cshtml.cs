using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages
{
    
    public class ListModel : PageModel
    
    {
         private string[] personas={"Angelica Arrieta ","Maria Teresa","Daniel Rivera", "Andres Beltran","Marcela Lasso"
            };

        public List<string> ListaPersonas{get;set;}
        public void OnGet()
        {
            ListaPersonas=new List<string>();
            ListaPersonas.AddRange(personas);
        }
    }
}
