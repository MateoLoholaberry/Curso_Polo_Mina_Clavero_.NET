using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Persona
    {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }

        public Persona()
        {
            NombreCompleto = "Juan Perez";
            Dni = 43421576;
        }


        protected string Clave()
        {
            return "32343532";
        }

        static public void Saludar()
        {
            Console.WriteLine("Hola!");
        }
    }
}
