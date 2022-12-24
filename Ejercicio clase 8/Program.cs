// Ejercicio

// Crear un programa que cumpla con los siguientes pasos

// 1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
// 2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
// 3) Declarar un vector de tipo double llamado promedios
// 4) Recorrer la matriz para su carga con elementos de tipo int
// 5) Recorrer la matriz para mostrar cada valor de la matriz
// 6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
// 7) Mostrar los promedios recorriendo el vector promedios

Console.WriteLine("Matriz");
Console.WriteLine();


Console.WriteLine("Ingresar la cantidad de filas:");
int filas = int.Parse(Console.ReadLine());


Console.WriteLine("Ingresar la cantidad de Columnas:");
int columnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];


double[] promedios = new double[filas];
double suma = 0;

for (int i = 0; i < filas ; i++)
{
    suma = 0;
    Console.WriteLine();
    Console.WriteLine($"Fila N°: {i+1}");

    for (int c = 0; c < columnas; c++)
    {
        Console.Write($"Columna N° {c+1}: ");
        numeros[i,c] = int.Parse(Console.ReadLine());

        suma += numeros[i,c];
    }

    promedios[i] = suma/columnas;
}



for (int i = 0; i < filas ; i++)
{

    Console.WriteLine();
    Console.WriteLine("=====================================");
    Console.WriteLine();
    Console.WriteLine($"Fila N°: {i+1}");

    for (int c = 0; c < columnas; c++)
    {
        Console.Write($"Columna N° {c+1}: ");
        Console.WriteLine(numeros[i,c]);
    }

    Console.WriteLine($"Promedio de la columna: {promedios[i]}");
}