-- COMANDOS DE DEFINICI�N

-- Comando para crear una base de datos nueva
CREATE DATABASE Agenda;

-- Comando para usar una base de datos especifica
USE Agenda;

USE Northwind;

-- Comando para eliminar una base de datos
DROP DATABASE Agenda;


-- Comando para crear una tabla
CREATE TABLE Personas (
	id INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL
	);

-- Comando para modificar una tabla (agregar nueva columna)
ALTER TABLE Personas
ADD edad2 INT NOT NULL;

-- Comando para modificar una tabla (borrar columna)
ALTER TABLE Personas
DROP COLUMN edad2;




-- COMANDOS DE MANIPULACI�N

-- Comando para insertar un registro en una tabla
INSERT INTO Personas (nombre, apellido, edad)
VALUES ('Ruben', 'Benegas', 26);


-- Comando para modificar un registro en una tabla
UPDATE Personas
SET nombre = 'Juan',
	apellido = 'Perez',
	edad = 23
WHERE id = 1;


UPDATE Personas
SET edad = 30
WHERE id = 1;



-- Comando para eliminar un registro en una tabla
DELETE FROM Personas
WHERE id = 1;

-- Comando para borrar todos los registros de la tabla
DELETE FROM Personas;


-- Comando para borrar todo los registros y reiniciar la tabla
TRUNCATE TABLE Personas;


-- Comando para hacer consultas en una tabla
SELECT * FROM Personas;

SELECT nombre, apellido FROM Personas;

SELECT id, nombre + ' ' + apellido AS descripcion FROM Personas;

SELECT id, nombre + ' ' + apellido AS descripcion FROM Personas
WHERE nombre = 'Ruben';