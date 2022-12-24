
//Console.WriteLine("Cuantas vueltas quiere dar?");
////var totalVueltas = int.Parse(Console.ReadLine());

//var contador = 0;
//string respuesta = "S";


//while (respuesta.ToUpper() != "N")
//{   
//    contador++; //contador = contador + 1
//    Console.WriteLine("Seguimos dando vueltas, vuelta n°: " + contador);
//    Console.WriteLine("Seguimos? (S/N)");
//    respuesta = Console.ReadLine();
//}


//   decl.     cond.      paso
for (int cantCara = 0; cantCara < 12; cantCara++)
{   
    Console.WriteLine($"Mi bolsita tiene {cantCara} caramelos");
}

Console.WriteLine();

var cantCar = 0;
while (cantCar < 12)
{
    Console.WriteLine("Mi bolsita tiene " + cantCar + " caramelos");
    cantCar++;
}

