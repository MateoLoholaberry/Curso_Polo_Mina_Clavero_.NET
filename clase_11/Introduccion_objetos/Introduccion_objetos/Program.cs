namespace Introduccion_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Instacia 1
            Perro firulais = new Perro();
            firulais.Color = "Negro";
            firulais.Edad = 4;
            firulais.Tamanio = "Grande";
            firulais.Raza = "Mastín Napolitano";

            
            //Instacia 2
            var fatiga = new Perro();
            fatiga.Color = "Blanco";
            fatiga.Edad = 2;
            fatiga.Tamanio = "Chico";
            fatiga.Raza = "Maltés";


            //Instacia 3
            var cartucho = new Perro();
            cartucho.Color = "Marrón";
            cartucho.Edad = 3;
            cartucho.Tamanio = "Medio";
            cartucho.Raza = "Chow Chow";


            //Lista de perros
            var listaPerros = new List<Perro>();
            listaPerros.Add(firulais);
            listaPerros.Add(fatiga);
            listaPerros.Add(cartucho);

            //Console.WriteLine(firulais.Raza);
            //Console.WriteLine(fatiga.Raza);
            //Console.WriteLine(cartucho.Raza);

            Console.WriteLine($"Hay {listaPerros.Count} perritos en la lista:");
            foreach (var item in listaPerros)
            {
                Console.Write(item.Raza + " -> ");
                item.Ladrar();
            }

        }
    }
}