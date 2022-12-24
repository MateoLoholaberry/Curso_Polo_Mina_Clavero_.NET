using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Modelo
{
    public abstract class Persona
    {
        private DateTime _fechaNacimiento;
        private int _numeroDeDocumento;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento 
        {
            get
            {
                return _fechaNacimiento.ToString("d/M/yyyy");
            }
            set
            {
                _fechaNacimiento = Convert.ToDateTime(value);
            }
        
        }

        public string NumeroDeDocumento
        {
            get
            {
                return _numeroDeDocumento.ToString();
            }
            set
            {
                //_numeroDeDocumento = Convert.ToInt32(value);

                var sePuedeConvertir = int.TryParse(value, out _numeroDeDocumento);

                if (!sePuedeConvertir)
                {
                    _numeroDeDocumento = 0;
                }
            }
        }

        public int ObtenerEdad()
        {
            var fechaHoraActual = DateTime.Today;

            var edadDateTime = fechaHoraActual - _fechaNacimiento;

            return (int)edadDateTime.TotalDays / 365;
        }
    }
}
