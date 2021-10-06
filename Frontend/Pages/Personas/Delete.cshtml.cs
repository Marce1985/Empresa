using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private readonly IRepositoryPersona _repo;
        public Persona Persona { get; set; }

        public DeleteModel(IRepositoryPersona repo){
            _repo=repo;
        }
        public void OnGet(string id)
        {
            Persona= _repo.GetPersona(id);
        }
        public void OnPost(string id)
        {
             _repo.DeletePersona(id);
        }
    }
}
