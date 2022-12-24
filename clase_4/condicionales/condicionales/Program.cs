// Ejemplo de condicional if

/*
Console.Write("Ingrese su edad: "); //Le pedimos al usuario que ingrese su edad
int edad = int.Parse(Console.ReadLine()); //Obtenemos la edad por teclado

Console.Write("Ingrese su equipo de futbol: ");
string equipo = Console.ReadLine();

Console.WriteLine("La edad ingresada es: " + edad);


if (edad < 18 && equipo == "River") //Evaluamos la edad
{
    Console.WriteLine("Usted es menor de edad");
}
else
{
    Console.WriteLine("Usted es mayor de edad");
}
*/


//Ejemplo if-elseif-else

/*
Console.WriteLine("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad < 0 || edad > 115)
{
    Console.WriteLine("La edad no es válida");
}
else if (edad < 12)
{
    Console.WriteLine("Va a la primaria");
}
else if (edad < 18)
{
    Console.WriteLine("Va al secundario");
}
else if (edad < 28)
{
    Console.WriteLine("Va a la facultad");
}
else
{
    Console.WriteLine("A trabajar, no queda de otra");
}
*/



// Ejemplo switch
Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicación");
Console.WriteLine("4 - División");
Console.WriteLine("Ingrese la operación a realizar: ");
string operacion = Console.ReadLine();

Console.WriteLine("Ingrese el primer número: ");
int nro1 = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese el segundo número: ");
int nro2 = int.Parse(Console.ReadLine());

double resultado = 0;

switch (operacion)
{
    case "1":
        //Console.WriteLine("Suamndo...");
        resultado = nro1 + nro2;
        break;
    case "2":
        //Console.WriteLine("Restando...");
        resultado = nro1 - nro2;
        break;
    case "3":
        //Console.WriteLine("Multiplicando...");
        resultado = nro1 * nro2;
        break;
    case "4" when nro2 != 0:
        //Console.WriteLine("Dividiendo...");
        resultado = nro1 / nro2;
        break;
    default:
        Console.WriteLine("Ingresó una opción no válida");
        break;
}

Console.WriteLine("El resultado es: " + resultado);