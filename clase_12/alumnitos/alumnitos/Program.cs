using alumnitos;

var alumno1 = new Alumno();
alumno1.Nombre = "Mateo";
alumno1.Apellido = "Loholaberry";
alumno1.Legajo = 1;
alumno1.DNI = "44.323.572";
alumno1.FechaNacimiento = new DateTime(2001, 08, 09);
alumno1.Calificaciones = new List<int>();

/*var alumno2 = new Alumno()
{
    Nombre = "Leandro",
    Apellido = "Beltramone",
    Legajo = 2,
    DNI = "43.276.231",
    FechaNacimiento = new DateTime(2000, 09, 10)
};*/

//Console.WriteLine($"Legajo: {alumno1.Legajo}, apellido: {alumno1.Apellido}");
//Console.WriteLine($"Legajo: {alumno2.Legajo}, apellido: {alumno2.Apellido}");

//alumno1.getInfo();
//alumno2.getInfo();


alumno1.CargarCalificacion(6, new DateTime(2022, 08, 09));
alumno1.CargarCalificacion(7);
alumno1.CargarCalificacion(6);

Console.WriteLine(alumno1.ObtenerPromedio());