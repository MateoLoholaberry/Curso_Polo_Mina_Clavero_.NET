using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Modelo
{
    public class Jubilado : Persona
    {
        public int AniosAportes { get; set; }
        public char Categoria { get; set; }

    }
}
