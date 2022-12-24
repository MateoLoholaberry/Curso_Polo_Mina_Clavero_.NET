using EjercicioBilletera;
using System.Collections.Specialized;
using EjercicioBilletera.Version2;

/*
var b1 = new Billetera();
var b2 = new Billetera();

b1.BilletesDe10 = 1;
b1.BilletesDe50 = 1;
b1.BilletesDe1000 = 5;

b2.BilletesDe500 = 5;
b2.BilletesDe1000 = 2;
Console.WriteLine(b1.Total());
Console.WriteLine(b2.Total());

var b3 = b1.Combinar(b2);

Console.WriteLine(b1.Total());
Console.WriteLine(b2.Total());
Console.WriteLine(b3.Total());

*/


/*-------------------------------*/

/*
var bc1 = new BilleteraCarlos();
var bc2 = new BilleteraCarlos();
bc1.BilletesDe10 = 1;
bc2.BilletesDe50 = 1;

Console.WriteLine(bc1.Total());
Console.WriteLine(bc2.Total());

var bc3 = bc1.Combinar(bc2);
Console.WriteLine(bc3.Total());

Console.WriteLine(bc1.Total());
Console.WriteLine(bc2.Total());
*/


/*-------------------------------*/

var b1 = new Billetera();
var bc2 = new BilleteraCarlos();

b1.BilletesDe500 = 1;
bc2.BilletesDe1000 = 2;
Console.WriteLine(b1.Total());
Console.WriteLine(bc2.Total());

var b3 = b1.Combinar(bc2);
Console.WriteLine(b3.Total());

Console.WriteLine(b1.Total());
Console.WriteLine(bc2.Total());