using herencia;

/*

var personas = new List<Persona>();
for (int i = 0; i < 10; i++)
{   
    var p = new Persona();
    personas.Add(p);
}

//Console.WriteLine($"{p.nombre} {p.apellido}");
*/



Console.WriteLine("Herencia");

var alumno = new Alumno();
Console.WriteLine(alumno.NombreCompleto);

Alumno.Saludar();