using GestorDePersonas.Interfaces;
using GestorDePersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Repositorio
{
    internal class RepositorioEnArchivos<T> : IRepositorio<T> where T : Persona
    {
        private string _pathArchivo = "C:\\persona.txt";



        public void Actualizar(T persona)
        {
            //Actualizo persona en un archivo
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            //Actualizo persona en un archivo
        }

        public void Eliminar(string numeroDocumento)
        {
            //Elimino persona en un archivo
        }

        public bool Existe(string numeroDocumento)
        {
            //Pregunto si existe persona en un archivo
            return false;
        }

        public bool Existe(T persona)
        {
            //Pregunto si existe persona en un archivo
            return false;
        }

        public void Insertar(T persona)
        {
            //Inserto persona en un archivo
        }
    }
}
