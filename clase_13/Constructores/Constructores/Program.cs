using Constructores.Modelos;

var persona1 = new Persona();
persona1.NombreCompleto = "Mateo Loholaberry";
persona1.NumeroDocumento = "41.233.331";
persona1.Edad = 21;
persona1.EstaCasado = false;

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Carlos"));


var persona2 = new Persona("Juan Perez", "40567241", 23, false);