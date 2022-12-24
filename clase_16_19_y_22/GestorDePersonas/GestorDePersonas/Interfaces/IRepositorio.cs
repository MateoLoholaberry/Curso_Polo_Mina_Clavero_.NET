using GestorDePersonas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Interfaces
{
    //Generics clase 22
    public interface IRepositorio<T> where T : Persona
    {
        void Insertar(T persona);
        void Eliminar(string numeroDocumento);
        void Actualizar(T persona);
        void Actualizar(string numeroDocumento, string nombre, string apellido);

        bool Existe(string numeroDocumento);
        bool Existe(T persona);
    }
}
