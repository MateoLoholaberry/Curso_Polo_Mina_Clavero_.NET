using GestorDePersonas.Interfaces;
using GestorDePersonas.Modelo;
using GestorDePersonas.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePersonas.Frontend
{
    public class MenuAplicacion
    {
        private IRepositorio<Persona> _repositorioPersona;

        public MenuAplicacion(IRepositorio<Persona> repositorioPersona)
        {
            _repositorioPersona = repositorioPersona;
        }

        public void Iniciar()
        {
            // Mostrar menú con 3 opciones:
            // 1) Agregar persona
            // 2) Listar persona
            // 3) Eliminar persona

            Console.WriteLine("Binevenido al gestor de personas!");
            int opcionElegidaMenuPrincipal;

            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Agregar persona");
                Console.WriteLine("2 - Listar personas");
                Console.WriteLine("3 - Eliminar persona");
                Console.WriteLine("4 - Salir");
                
                opcionElegidaMenuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (opcionElegidaMenuPrincipal)
                {
                    case 1:
                        MostrarAgregarPersona();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Opción Inválida");
                        break;
                }

            } while (opcionElegidaMenuPrincipal != 4);


        }


        private void MostrarAgregarPersona()
        {

            Console.WriteLine("Ingrese el tipo de persona a agregar:");

            Console.WriteLine("1- Empleado");
            Console.WriteLine("2- Desempleado");
            Console.WriteLine("3- Jubilado");

            Persona personaAAgregar;

            var opcionTipoPersona = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido:");
            var apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de nacimiento (formato: DD/MM/AAAA):");
            var fechaNacimiento = Console.ReadLine();


            switch (opcionTipoPersona)
            {
                case 1:
                    //Empleado
                    var empleado = new Empleado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento
                    };

                    Console.WriteLine("Ingrese ocupación:");
                    empleado.Ocupacion = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese empresa en la que trabaja:");
                    empleado.Empresa = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese obra social:");
                    empleado.ObraSocial = Console.ReadLine();

                    personaAAgregar = empleado;

                    break;
                case 2:
                    //Desempleado
                    var desempleado = new Desempleado
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento
                    };

                    Console.WriteLine("Ingrese última ocupación:");
                    desempleado.UltimaOcupacion = Console.ReadLine();

                    Console.WriteLine("Ingrese última empresa en la que trabajó:");
                    desempleado.UltimaEmpresa = Console.ReadLine();

                    Console.WriteLine("Es discapacitado: SI/NO");
                    var esDiscapacitadoOpcion = Console.ReadLine();

                    if (esDiscapacitadoOpcion.ToLower() == "si")
                    {
                        desempleado.EsDiscapacitado = true;
                    }

                    personaAAgregar = desempleado;

                    break;

                default:
                    Console.WriteLine("Opción ingresada incorrecta");
                    return;
            }

            _repositorioPersona.Insertar(personaAAgregar);
            Console.WriteLine("Persona agregada correctamente");
        }

    }
}
