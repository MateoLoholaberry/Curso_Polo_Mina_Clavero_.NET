// Calculos
Console.WriteLine("Este programa calcula la superficie de un rectángulo.");
Console.WriteLine();

Console.WriteLine("Ingrese la base del rectángulo:");
double baseRectangulo = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese la altura del rectángulo:");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo =
    baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);


bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    // Mostrar mensaje solamente si es mayor a 10
    Console.WriteLine("La superficie es mayor a 10");
}

Console.ReadKey();

