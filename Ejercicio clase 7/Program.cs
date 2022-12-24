// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Escribe un programa que:

// 1) Pida 10 números al usuario.
// 2) Obtener la suma de todos los números ingresados.
// 3) Obtener cual es el mayor de todos los números.
// 4) Obtener cual es el menor de todos los números.
// 5) Obtener el promedio de todos los números.
// 6) Mostrar todos los números ingresados por pantalla.
// 7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Console.WriteLine("Ingrese diez números enteros:");
int[] numeros = new int[10];
int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el número {i+1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];

}


int mayor  = numeros[0];
int menor = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{

    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    else if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("Los números ingresados fueron:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine($"La suma de todos los números ingresados fue: {suma}");
Console.WriteLine($"El mayor de todos los números ingresados fue: {mayor}");
Console.WriteLine($"El menor de todos los números ingresados fue: {menor}");
Console.WriteLine($"El promedio de todos los números ingresados fue: {suma/numeros.Length}");