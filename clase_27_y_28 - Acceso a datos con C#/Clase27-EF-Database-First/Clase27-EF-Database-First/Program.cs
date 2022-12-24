// See https://aka.ms/new-console-template for more information
using Clase27_EF_Database_First.Models;
using Microsoft.EntityFrameworkCore;
using New.Namespace;

Console.WriteLine("Hello, World!");

var ctx = new NorthwindContext();


// Agregar un nuevo Customer
/*var newCustomer = new Customer()
{
    CustomerId = "MATEO",
    CompanyName = "Mateo Loholaberry",
};

newCustomer.Orders.Add(new Order()
{
    CustomerId=newCustomer.CustomerId,
    OrderDate = DateTime.Now,
});

// Agregamos el customer
ctx.Add(newCustomer);
ctx.SaveChanges();*/




// Editar un nuevo Customer
/*var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "MATEO");

if (reg != null)
{
    reg.CompanyName = "Mateo Loholaberry editado";
    ctx.SaveChanges();
}*/


//ELIMINAR
/*var regOrders = ctx.Orders.Where(orden => orden.CustomerId == "MATEO");
ctx.RemoveRange(regOrders);

var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "MATEO");
ctx.Remove(regCustomer);
ctx.SaveChanges();
*/


Console.WriteLine("Lista de Customers");
Console.WriteLine();
Console.WriteLine("==========================");
//var customers = ctx.Customers;
/* var customers = ctx.Customers.Select(selector =>
                new {IdCustomer = selector.CustomerId,
                NameCustomer = selector.CompanyName});

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.IdCustomer} - {customer.NameCustomer}");
}

Console.ReadKey(); */


// SELECT
var customers = ctx.Customers;

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.CustomerId} - {customer.CompanyName}");
}

Console.WriteLine("==================================");
Console.WriteLine();
Console.WriteLine("Ingrese al Id que deasea consultar");
string idCustomer = Console.ReadLine();

// Consulta si existe en base de datos (Any)
bool anyCustomer = ctx.Customers.Any(x => x.CustomerId == idCustomer.ToUpper());

if (anyCustomer)
{
    Console.WriteLine("Existe! Todo ok.");

    // Consulta por el customer y sus pedidos
    var customer = ctx.Customers.Include(i => i.Orders)
        .First(c => c.CustomerId == idCustomer.ToUpper());

    
    Console.WriteLine();
    Console.WriteLine($"IdCustomer: {customer.CustomerId} - CompanyName: {customer.CompanyName}");
    Console.WriteLine();
    Console.WriteLine("Orders");
    foreach (var order in customer.Orders)
    {
        Console.WriteLine($"OrderId: {order.OrderId} - OrderDate: {order.OrderDate}");
    }
    Console.WriteLine("===================================");
    Console.WriteLine();
}
else
{
    Console.WriteLine("El idCustiomer ingresado no existe en la bd");
}