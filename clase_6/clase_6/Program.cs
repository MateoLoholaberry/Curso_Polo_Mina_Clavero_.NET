
/*
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla
2) Pedir el nombre de una persona
3) saludar con un texto personalizado
4) Preguntar si se quiere continuar.
5) Si la respuesta s repetir desde el punto 1
6) Si la respuesta es "n" finalizar el programa correctamente
7) Si la respuesta no es ni "s" ni "n" finalizar el programa pero
   mostrando un mensaje que diga opción no válida.
*/


// Alternativa con While
/*
string respuesta = "S";

while (respuesta.ToUpper() == "S")
{
    // Borrar pantalla
    Console.Clear();

    // Pedir nombre persona
    Console.WriteLine("Ingrese su nombre:");
    var nombrePersona = Console.ReadLine();

    Console.WriteLine($"Hola {nombrePersona}!");

    Console.WriteLine("Desea continuar (S/N)");
    respuesta = Console.ReadLine();

}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente!");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Opción no válida");
    Console.WriteLine("Programa finalizado");
    Console.ReadKey();
}

*/


// Alternativa con Do-While
string respuesta;

do
{
    // Borrar pantalla
    Console.Clear();

    // Pedir nombre persona
    Console.WriteLine("Ingrese su nombre:");
    var nombrePersona = Console.ReadLine();

    Console.WriteLine($"Hola {nombrePersona}!");

    Console.WriteLine("Desea continuar (S/N)");
    respuesta = Console.ReadLine();
} 
while (respuesta.ToUpper() == "S");

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente!");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Opción no válida");
    Console.WriteLine("Programa finalizado");
    Console.ReadKey();
}