/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Matrices - Arrays

Console.Write("Ingrese cuantos alumnos tiene: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());


Console.Write("Ingrese las notas de cada alumno: ");
int[] notas = new int[cantidadAlumnos];

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Notas del alumno {i+1}:");
    notas[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("================================");

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"La nota del alumno N° {i+1} = {notas[i]}");
}

//===========================================

*/


//Matrices de 2 dismensiones

Console.WriteLine("Ingrese las notas de los examenes de sus alumnos");
Console.WriteLine();

//Determina las columnas
Console.WriteLine("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());

//Determina las filas
Console.WriteLine("Ingrese la cantidad de notas por alumno: ");
int cantidadNotas = int.Parse(Console.ReadLine());

int[,] notas = new int[cantidadNotas, cantidadAlumnos];

//cantidad de filas
int lengthFilas = notas.GetUpperBound(0) + 1;

//cantidad de columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;


//Recorremos columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine($"notas del alumno N° {columna + 1}:");

    //Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
	{
        Console.WriteLine($"Cargue la nota {fila + 1}:");
        notas[fila, columna] = int.Parse(Console.ReadLine());
	}
}


//Mostramos las notas

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N° {columna + 1}:");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Nota N°: {fila+1} = {notas[fila,columna]}");
    }

}