using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces2.Models
{
    internal class Docente : IPersona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int Horas { get; set; }

    }
}
