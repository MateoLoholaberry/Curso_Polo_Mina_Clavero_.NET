using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejoras_en_CSharp.clases
{
    public static class MisExtensiones
    {

        //Métodos de extensión
        //Permiten generar un método nuevo a un tipo ya existente.
        //Ejemplos: a Proovedor y a string
        public static int CalcularCreditos(this Proveedor p)
        {
            if (p.Nombre == "Juan")
            {
                return 100;
            }
            return 50;
        }

        public static int ContarPalabras(this string s, string sep = " ")
        {
            return s.Split(sep).Length;
        }
    }
}
