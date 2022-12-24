using GestorDePersonas.Frontend;
using GestorDePersonas.Modelo;
using GestorDePersonas.Repositorio;
//Gestor de personas Trabajadoras (empleados, desempleados, jubilados)

/*
 Insertar personas en una base de datos, mostrar datos
 de una determinada persona o de todas las personas
*/

var menuAplicacion = new MenuAplicacion(new RepositorioEnArchivos<Persona>());

menuAplicacion.Iniciar();