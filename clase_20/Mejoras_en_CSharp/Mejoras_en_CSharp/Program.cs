using Mejoras_en_CSharp.clases;


//Inicializador
var p = new Persona
{
    Nombre = "Juan",
    Apellido = "Perez"
};

//Es lo mismo que esto
var p2 = new Persona();
p2.Nombre = "Juan";
p2.Apellido = "Perez";


var p3 = new Persona("Juan", "Perez");

var pr = new Proveedor("Julio", "Perez");
Console.WriteLine(pr.CalcularCreditos());


var miTexto = "Cuantas palabras tiene este texto?";
Console.WriteLine(miTexto.ContarPalabras());

/*-------------------------------------------*/

//Tipos anónimos
//Son solo propiedades del tipo lectura
var auto = new
{
    Marca = "Ford",
    Modelo = "Mustang",
    Anio = "1969"
};

Console.WriteLine(auto.Marca);
Console.WriteLine(auto.Modelo);



var pr2 = new
{
    pr.Nombre,
    pr.Apellido,
    TipoProveedor = "Limpieza",
    edad = 23
};

Console.WriteLine();
Console.WriteLine(pr2.Nombre);
Console.WriteLine(pr2.Apellido);
Console.WriteLine(pr2.TipoProveedor);


/*-------------------------------------------*/

//Expresiones Lambda

//Ejemplo 1
int[] numeros = { 1, 2, 3, 4, 5, 6, 7};
int numerosImpares = numeros.Count(n => n % 2 == 1);

Console.WriteLine(numerosImpares);



//Ejemplo 2
List<Persona> misClientes = new List<Persona>();
misClientes.Add(new Persona { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Persona { Apellido = "Moscoso", Nombre = "Carlos"});


var juanes = misClientes.Where(
    cadaCliente => cadaCliente.Nombre == "Juan");

foreach (var item in juanes)
{
    Console.WriteLine(item.Nombre);
}