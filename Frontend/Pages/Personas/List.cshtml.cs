using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;



namespace Frontend.Pages
{

    public class ListModel : PageModel

    {

        private readonly IRepositoryPersona _repo;
        

        public IEnumerable<Persona> Personas { get ; set ; }

        public ListModel(IRepositoryPersona repositoryPersona)
        {
            _repo = repositoryPersona;
        }

        //  private string[] personas={"Angelica Arrieta ","Maria Teresa","Daniel Rivera", "Andres Beltran","Marcela Lasso"
        //     };

        // public List<string> ListaPersonas{get;set;}
        public void OnGet()
        {
            // ListaPersonas=new List<string>();
            // ListaPersonas.AddRange(personas);
            Personas = _repo.GetAllPersona();

        }
    }
}
