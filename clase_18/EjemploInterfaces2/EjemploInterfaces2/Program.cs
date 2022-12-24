using EjemploInterfaces2.Models;

var alumno = new Alumno()
{
    Nombre = "Joaquín",
    Apellido = "Mateos" ,
    DNI = "12376221",
    Legajo = 1234
};

var docente = new Docente()
{
    Nombre = "Eze",
    Apellido = "Etchecoin",
    DNI = "12341231",
    Horas = 26
};


string ObtenerDatos(IPersona persona)
{
    var datos = persona.Nombre + " " + persona.Apellido;
    return datos;
}


List<IPersona> ObtenerPersonasByNombre(List<IPersona> personas, string nombre)
{
    var nuevaLista = new List<IPersona>();
    foreach (var p in personas)
    {
        if (p.Nombre == nombre)
        {
            nuevaLista.Add(p);
        }
    }
    return nuevaLista;
}




Console.WriteLine(ObtenerDatos(docente));


var listado = new List<IPersona>();
listado.Add(docente);
listado.Add(alumno);

var nuevoListado = ObtenerPersonasByNombre(listado, "Eze");

Console.WriteLine(nuevoListado.Count);