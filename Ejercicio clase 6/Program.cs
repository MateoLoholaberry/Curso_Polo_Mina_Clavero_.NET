﻿/*
1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.

Nota:
Obviamente hay que hacer un bucle y crear un contador de intentos.
Sean honestos con ustedes mismos y usen sus propias neuronas para resolver el problema, y aunque no lo terminen lo importante es intentarlo.
*/

int nroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int nroUsuario = 0;
int contador = 0;

while (nroSecreto != nroUsuario)
{
    Console.Clear();
    Console.WriteLine("Intenta adivinar el número secreto dentro del rango (1 - 20).");
    Console.Write("Ingresa un número: ");
    nroUsuario = int.Parse(Console.ReadLine());
    contador += 1;

    if (nroUsuario > nroSecreto)
    {
        Console.WriteLine("El número ingresado es más grande que el número secreto.");
    }
    else if (nroUsuario < nroSecreto)
    {
        Console.WriteLine("El número ingresado es menor al número secreto.");
    }
    else
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {nroSecreto}");
        Console.WriteLine($"Lo has logrado en {contador} intentos.");
    }

    Console.Write("Presiona enter para continuar...");
    Console.ReadLine();
}

Console.Write("Fin del programa.");