/*
1) Arrays 
2) Listas
3) Colas
4) Pilas
5) Diccionarios
etc...
*/


// Arrays
/*
var miArray = new int[10];

// Recorro un array
for (int i = 0; i < miArray.Length; i++)
{
    Console.WriteLine(miArray[i]);
}

foreach (var item in miArray)
{
    Console.WriteLine(item);
}
*/


//Listas
/*
var personas = new List<string>();

personas.Add("Ezequiel");
personas.Add("Eugenio");
personas.Add("Joaquin");


foreach (var persona in personas)
{
    Console.WriteLine(persona);
}
 */


/*
 Escribir un programa que permita al usuario confeccionar
 una lista de nombres. Se debe ofrecer las siguientes opciones:
 Agregar un elemento (al final de la lista o en una posición determinada),
 quitar elemento, mostrar en que posición se encunetra un determinado
 elemento, invertir lista
 */


//Tema Count y Capacity de las listas
/*
var ListaNumeros = new List<int>();

var random = new Random();

for (int i = 0; i < 10; i++)
{
    var numero = random.Next();
    ListaNumeros.Add(numero);

    var count = ListaNumeros.Count;
    var capacity = ListaNumeros.Capacity;

    Console.WriteLine($"Count: {count}, Capacity: {capacity}");
} */



// Ejemplo usando listas
var listaNombres = new List<string>();

Console.WriteLine("Binevenido a Lista");

string entradaUsuario;

do
{
    Console.WriteLine();
    Console.WriteLine("Sleccione una de las siguientes opciones");

    Console.WriteLine("1) Agregar un elemento");
    Console.WriteLine("2) Quitar un elemento");
    Console.WriteLine("3) Ubicar un elemento");
    Console.WriteLine("4) Invertir la lista");
    Console.WriteLine("5) Ver el contenido de la lista");
    Console.WriteLine("0) Salir");

    entradaUsuario = Console.ReadLine();

    switch (entradaUsuario)
    {
        case "1":
            //Agregar un elemento
            Console.WriteLine("Ingrese el elemento");
            var nuevoElemento = Console.ReadLine();

            Console.WriteLine("Donde desea agregar el elemento");
            Console.WriteLine("1) Al final");
            Console.WriteLine("2) En una posición determinada");

            var opcionParaIngresar = Console.ReadLine();
            switch (opcionParaIngresar)
            {
                case "1":
                    //Al final
                    listaNombres.Add(nuevoElemento);
                    break;
                case "2":
                    //Insertar elemento en una posición determinada
                    Console.WriteLine("Ingrese posición:");
                    var posi = int.Parse(Console.ReadLine());

                    listaNombres.Insert(posi, nuevoElemento);
                    break;
            }
            break;

        case "2":
            //Quitar elemento
            Console.WriteLine("Ingrese el elemento que desea quitar: ");
            var elementoARemover = Console.ReadLine();
            listaNombres.Remove(elementoARemover);
            break;

        case "3":
            //Ubicar un Elemento
            Console.WriteLine("Ingrese el elemento que desea ubicar");
            var elementoAUbicar = Console.ReadLine();
            var posicion = listaNombres.IndexOf(elementoAUbicar);
            if (posicion > -1)
            {
                Console.WriteLine($"El elemento se encuentra en la posición: {posicion}");
            }
            else
            {
                Console.WriteLine("El elemento no existe");
            }
            break;

        case "4":
            //Invertir lista
            listaNombres.Reverse();
            Console.WriteLine("La lista se ha invertido.");
            break;

        case "5":
            //Ver lista
            if (listaNombres.Count == 0)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                foreach (var item in listaNombres)
                {
                    Console.WriteLine(item);
                }
            }
            break;

    }
} while (entradaUsuario != "0");

