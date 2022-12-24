/* Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes) */

using Ejercicio_clase_13.Modelos;

var billetera1 = new Billetera
{
    BilletesDe10 = 10,
    BilletesDe20 = 5,
    BilletesDe50 = 2,
    BilletesDe100 = 1,
    BilletesDe200 = 0,
    BilletesDe500 = 1,
    BilletesDe1000 = 2
};

var billetera2 = new Billetera
{
    BilletesDe10 = 10,
    BilletesDe20 = 5,
    BilletesDe50 = 2,
    BilletesDe100 = 1,
    BilletesDe200 = 0,
    BilletesDe500 = 1,
    BilletesDe1000 = 0
};

Console.WriteLine("Billeteras 1 y 2 antes de combinarlas");
Console.WriteLine(billetera1.total());
Console.WriteLine(billetera2.total());

var billetera3 = billetera1.combinar(billetera2);

Console.WriteLine();
Console.WriteLine("después de combinar las billeteras 1 y 2");
Console.WriteLine($"Billetera 1: {billetera1.total()}");
Console.WriteLine($"Billetera 2: {billetera2.total()}");
Console.WriteLine($"Billetera 3: {billetera3.total()}");