using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnitos
{
    internal class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public List<int> Calificaciones { get; set; }



        /*
         public void getInfo()
         {
             Console.WriteLine($"Legajo: {Legajo}, apellido: {Apellido}");
         }
        */



        // Sobrecargas

        public void CargarCalificacion(int Nota, DateTime Fecha)
        {
            Calificaciones.Add(Nota);

            Console.WriteLine($"{Fecha.ToString("dd MMM yyyy")} Se asignó la calificación {Nota} al legajo {Legajo}");
        }


        public void CargarCalificacion(int Nota)
        {
            Calificaciones.Add(Nota);

            var Fecha = DateTime.Now;
            Console.WriteLine(Fecha.ToString("dd MMM yyyy") + $" se asigno la calificación {Nota} al legajo {Legajo}");
        }




        public decimal ObtenerPromedio()
        {
            decimal acumulador = 0;

            foreach (var nota in Calificaciones)
            {
                acumulador += nota; //= acumulador = acumulador + nota
            }

            decimal promedio = acumulador / Calificaciones.Count;
            
            return promedio;
        }


    }
}
