using GestorDePersonas.Interfaces;
using GestorDePersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Repositorio
{
    public class RepositorioEnDiccionario<T> : IRepositorio<T> where T : Persona
    {
        //Usamos diccionarios para guardar las personas.
        public Dictionary<string, T> Personas { get; set; }

        public RepositorioEnDiccionario()
        {
            Personas = new Dictionary<string, T>();
        }

        public void Insertar(T persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento);

            if (!personaExiste)
            {
                Personas[numeroDocumento] = persona;
            }

        }

        public void Eliminar(string numeroDocumento)
        {
            Personas[numeroDocumento] = null;    
        }

        public void Actualizar(T persona)
        {
            var personaAActualizar = Personas[persona.NumeroDeDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }

        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            var personaAActualizar = Personas[numeroDocumento];

            if (personaAActualizar != null)
            {
                personaAActualizar.Nombre = nombre;
                personaAActualizar.Apellido = apellido;
            }
            
        }


        public bool Existe(T persona)
        {
            return Existe(persona.NumeroDeDocumento);
        }

        public bool Existe(string numeroDeDocumento)
        {
            return Personas.ContainsKey(numeroDeDocumento);
        }
    }
}
