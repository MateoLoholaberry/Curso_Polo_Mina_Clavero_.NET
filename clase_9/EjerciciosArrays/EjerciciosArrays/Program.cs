Console.WriteLine("Ingrese el tamaño deseado para el listado:");
int n = int.Parse(Console.ReadLine());

int[] vector = new int[n];

Random aleatorio = new Random();



for (int i = 0; i < vector.Length; i++)
{

    vector[i] = aleatorio.Next(100);

}

int contador = 0;

foreach (var i in vector)
{
    contador++;
    Console.WriteLine($"{contador}: {i}");
}


Console.WriteLine();
Console.WriteLine("Ingrese posición a modificar");
var k = int.Parse(Console.ReadLine());

if (k > vector.Length || k <= 0)
{
    Console.WriteLine("Índice incorrecto");
}
else
{

    while (true) // Bucle infinito
    {
        Console.WriteLine("Ingrese el nuevo valor:");
        int nuevoValor = int.Parse(Console.ReadLine());
        if (nuevoValor > 0 && nuevoValor < 100)
        {

            vector[k - 1] = nuevoValor;
            break; // Salir del bucle infinito
        }
        else
        {
            Console.WriteLine("Recuerde que el valor debe ser positivo mayor que 0 y menor que 100.");
        }
    }


    contador = 0;

    foreach (var i in vector)
    {
        contador++;
        Console.WriteLine($"{contador}: {i}");
    }
}

