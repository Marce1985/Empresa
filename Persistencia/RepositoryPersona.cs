using System.Runtime.ExceptionServices;
using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositoryPersona : IRepositoryPersona
    {
        private readonly AplicationContext _appContext;

        List<Persona> personas;

        // public RepositoryPersona() => personas = new List<Persona>(){
        //         new Persona{
        //             id,nombre,edad,telefono,direccion
        //         }
        //     };
         public RepositoryPersona(AplicationContext appContext){
             _appContext= appContext;
         }
        public RepositoryPersona(){}
       
        Persona IRepositoryPersona.AddPersona(Persona persona)
        {
            var personaAdicionada= _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
             
            return personaAdicionada.Entity;
        }

        void IRepositoryPersona.DeletePersona(string idPersona)
        {
            var personaEncontrada= _appContext.Personas.FirstOrDefault(p=> p.id.Equals(idPersona));
            if(personaEncontrada==null)
              return;
              _appContext.Personas.Remove(personaEncontrada);
              _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositoryPersona.GetAllPersona()
        {
            return _appContext.Personas.AsNoTracking();
        }

        Persona IRepositoryPersona.GetPersona(string idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p=> p.id.Equals(idPersona));
            
        }

        Persona IRepositoryPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada= _appContext.Personas.FirstOrDefault(p=> p.id.Equals(persona.id));
            if (personaEncontrada!=null)
            {
                personaEncontrada.nombre=persona.nombre;
                personaEncontrada.edad=persona.edad;
                personaEncontrada.direccion=persona.direccion;
                personaEncontrada.telefono=persona.telefono;

                _appContext.SaveChanges();
              
            }
            return personaEncontrada;
        }
    }
}