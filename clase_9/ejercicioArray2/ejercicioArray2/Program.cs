Console.WriteLine("Ingrese la cantidad de número primos que quiere ver:");
int n = int.Parse(Console.ReadLine());

int[] primos = new int[n];

int posicion = 0;
int aux;
int numero = 1;

while (posicion < primos.Length)
{
    aux = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero%i == 0)
        {
            aux++;
        }
    }

    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;
    }

    numero++;
}
Console.WriteLine($"Los primeros {primos.Length} números primos son:");
foreach (var i in primos)
{
    Console.WriteLine(i);
}