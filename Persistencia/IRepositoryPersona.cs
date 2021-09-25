using Dominio;
using  System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositoryPersona
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AdPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(id idPersona);
        Persona GetPersona(id idPersona);
         
    }
}