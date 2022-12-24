using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mejoras_en_CSharp.clases
{
    //Clases parciales
    public partial class Persona
    {
        private string _apellido;
        //Propiedad NO autoimplementada
        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        //Métodos parciales
        public partial int CalcularEdad()
        {
            return 21;
        }
    }
}
