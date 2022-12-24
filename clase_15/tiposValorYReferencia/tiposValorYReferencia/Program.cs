
//Primera Parte - Tipos de variable por valor
/*
int primerNumero = 1986;
int segundoNumero = primerNumero;

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);

primerNumero = 1978;

Console.WriteLine(primerNumero);
Console.WriteLine(segundoNumero);
*/



using tiposValorYReferencia.Modelos;

//Segunda Parte - Tipos de variable por referencia

/*
var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "Juan Perez"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miSegundaClase.Nombre);


miPrimerClase.Nombre = "Andrés Gomez";
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);
*/



//Tercer Parte
/*
var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "PEPE"
};

var miSegundaClase = new MiClase
{
    Id = 2,
    Nombre = "QUINO"
};

var miLista = new List<MiClase>();
miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);

foreach (var item in miLista)
{
    Console.WriteLine(item.Nombre);
    if (item.Id == 1)
    {
        item.Nombre = "ROBERTO";
    }
}

Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);
*/


//Cuarta Parte

var primerPersona = new Persona
{
    Nombre = "Joaquín",
    Apellido = "Mateos",
};


var primerDocente = new Docente
{
    Salario = 70000,
    Nombre = "Juan Pablo",
    Apellido = "Ferreira"
};


var primerAlumno = new Alumno
{
    Legajo = 1234,
    Nombre = "Ricardo",
    Apellido = "Rodriguez"
};

var personas = new List<Persona>();
personas.Add(primerPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);


foreach (var persona in personas)
{
    //Console.WriteLine(persona.Nombre);

    if (persona.GetType() == typeof(Docente))
    {
        var docente = (Docente)persona;
        Console.WriteLine(docente.Salario);
    }

}