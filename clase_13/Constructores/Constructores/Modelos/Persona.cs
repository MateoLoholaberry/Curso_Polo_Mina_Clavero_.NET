using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores.Modelos
{
    internal class Persona
    {
        //Constructor
        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva persona");
        }

        //Sobrecarga del método constructor
        public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
        {
            NombreCompleto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Edad = edad;
            EstaCasado = estaCasado;
        }


        //Propiedades
        public string NombreCompleto { get; set; }
        public string NumeroDocumento{ get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }


        //Método
        public string ObtenerSaludo()
        {
            return $"Hola soy {NombreCompleto}";
        }

        //Sobrecargas del método anterior
        public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
        {
            return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
        }
    }
}
