
// Borra la pantalla del terminal
Console.Clear();

// Pedimos que el usuario introduzca su nombre
Console.WriteLine("Ingrese su nombre: ");

// Leemos el nombre del usuario

string nombre = Console.ReadLine();


Console.Write("Hola " + nombre);
Console.WriteLine(", Este es mi segundo programa!");

// Pedimos al usuario que introduzca su apellido
Console.WriteLine("Ahora, por favor, ingrese su apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Pulse una tecla para finalizar...");
//Console.ReadKey();