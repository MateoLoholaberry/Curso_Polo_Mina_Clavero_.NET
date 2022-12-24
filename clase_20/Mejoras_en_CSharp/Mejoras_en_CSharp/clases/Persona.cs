using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejoras_en_CSharp.clases
{
    //Clases parciales
    //Estan divididas en n cantidad de archivos
    public partial class Persona
    {
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }



        //Propiedad autoimplementada
        public string Nombre { get; set; }


        //Métodos parciales
        public partial int CalcularEdad();

    }
}
