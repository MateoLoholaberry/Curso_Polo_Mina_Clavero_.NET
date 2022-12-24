// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//variables constantes
const string constanteTexto = "Esto es una constante";


// Datos númericos
byte numero_byte = 0;
int numero_integer = 120;
double numero_double = 0;
long numero_long = 0;
float numero_float = 0.5F;

// Datos lógicos
bool dato_bool1 = false;
bool dato_bool2 = true;

// Datos de texto
string dato_string = "Texto de prueba";

// Instrucción de salida
Console.WriteLine(dato_string);

dato_string = "Texto modificado";
Console.WriteLine(dato_string);

Console.WriteLine(numero_integer);

Console.WriteLine(dato_bool1);

// el Console.write NO hace un salto de linea
Console.Write(dato_string);
Console.Write(numero_integer);

Console.WriteLine("Escriba un texto:");
// Instrucción de entrada
Console.ReadLine();

