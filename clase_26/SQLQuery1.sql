-- CONSULTAS CON SELECT Y WHERE

/* SELECT * FROM Person.Person 
-- WHERE LastName = 'Turner' OR LastName = 'Cook';
-- WHERE LastName IN ('Turner', 'Cook');
-- WHERE FirstName LIKE 'A%';
*/



/* SELECT ProductID,
Name AS [Nombre de Producto], -- Cuando lo ponemos entre '[]' Permite espacios
Color, 
StandardCost, 
Weight
FROM Production.Product
-- WHERE Color IS NOT NULL;
-- ORDER BY StandardCost DESC;
ORDER BY StandardCost DESC, Name;
*/


-- SELECT COUNT(BusinessEntityID) FROM Person.Person;