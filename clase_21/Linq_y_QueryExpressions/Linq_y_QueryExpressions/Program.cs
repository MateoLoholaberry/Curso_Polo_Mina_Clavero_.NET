using Linq_y_QueryExpressions;

//Repaso expresiones Lambda
//ejemplo 1
/*
int[] numeros = { 5, 4, 6, 8, 7, 9, 1 };

int todosLosNumeros = numeros.Count();
Console.WriteLine(todosLosNumeros);


int numeroImpares = numeros.Count(n => n % 2 == 1);
Console.WriteLine(numeroImpares);
*/


//Ejemplo 2

var misClientes = new List<Cliente>();
misClientes.Add(new Cliente { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Cliente { Apellido = "Moscoso", Nombre = "Carlos" });


var juanes = misClientes.Where(
    cadaCliente => cadaCliente.Nombre == "Juan");

foreach (var item in juanes)
{
    Console.WriteLine(item.Nombre);
}


/*--------------------------------------*/

//Query Expression y LinQ

//Ejemplo 1

//Fuente de datos
int[] puntajes = { 90, 71, 82, 93, 75, 82 };

IEnumerable<int> resultados =
    from puntaje in puntajes
    where puntaje > 80
    orderby puntaje descending
    select puntaje;


foreach (var r in resultados)
{
    Console.WriteLine(r);
}




IEnumerable<Cliente> resultados2 =
    from cliente in misClientes
    where cliente.Nombre == "Juan"
    orderby cliente.Nombre descending
    select cliente;
    

foreach (var c in resultados2)
{
    Console.WriteLine(c.Nombre);
    Console.WriteLine(c.Apellido);
}