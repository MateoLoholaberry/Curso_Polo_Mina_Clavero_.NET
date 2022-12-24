// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Arrays

string[] cars = { "Ford", "Fiat", "BMW", "Toyota"};

Console.WriteLine(cars[0]);

string[] frutas = new string[4];

frutas[0] = "Pera";
frutas[1] = "Manzana";
frutas[2] = "Banana";
frutas[3] = "Kiwi";
//frutas[4] = "Naranjas";


Console.WriteLine(frutas[2]);
Console.WriteLine(frutas[3]);
Console.WriteLine("");
//Console.WriteLine(frutas[4]);


int[] numeros = new int[5];
Console.WriteLine($"El array tiene {numeros.Length} posiciones.");
//sin poner un bucle

//Console.WriteLine("Ingrese los siguientes 5 números:");
//ints[0] = int.Parse(Console.ReadLine());
//ints[1] = int.Parse(Console.ReadLine());
//ints[2] = int.Parse(Console.ReadLine());
//ints[3] = int.Parse(Console.ReadLine());
//ints[4] = int.Parse(Console.ReadLine());


//Con un bucle
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor ingrese el número {i+1}:");
    numeros[i] = int.Parse(Console.ReadLine());
    suma += numeros[i];
}

Console.WriteLine();
Console.WriteLine("Los números ingresados son:");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"número {i+1} = {numeros[i]}");
}

Console.WriteLine();
Console.WriteLine($"El total de los números ingresados es: {suma}");
