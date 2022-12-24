using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejoras_en_CSharp.clases
{
    public class Proveedor : Persona
    {
        public Proveedor(string nombre, string apellido)
            //Llamar al constructor de la clase base o de la que hereda
            : base(nombre, apellido)
        {

        }
    }
}
