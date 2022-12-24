using Encapsulamiento.Modelo;

var miAuto = new Auto();

Console.WriteLine("Ingrese el tipo de motor de su auto:");
var tipoMotor = Console.ReadLine();

miAuto.TipoDeMotor = tipoMotor;

Console.WriteLine(miAuto.TipoDeMotor);