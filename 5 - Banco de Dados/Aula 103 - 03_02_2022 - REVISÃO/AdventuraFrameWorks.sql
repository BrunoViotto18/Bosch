
USE AdventureWorks2017;


SELECT TOP 10 *
FROM Sales.SalesOrderDetail

SELECT TOP 10 AVG(LineTotal) AS 'Media Valores'
FROM Sales.SalesOrderDetail


SELECT TOP 10 MIN(LineTotal) AS 'Mínimo Valores'
FROM Sales.SalesOrderDetail

SELECT TOP 10 LineTotal AS 'Mínimo Valores'
FROM Sales.SalesOrderDetail
ORDER BY LineTotal


SELECT TOP 10 MAX(LineTotal) AS 'Máximo Valores'
FROM Sales.SalesOrderDetail

SELECT TOP 10 LineTotal AS 'Mínimo Valores'
FROM Sales.SalesOrderDetail
ORDER BY LineTotal DESC



SELECT AVG(LineTotal) FROM (SELECT TOP 10 * FROM Sales.SalesOrderDetail) AS T


SELECT SpecialOfferId, SUM(UnitPrice) AS Soma_Unitária
FROM Sales.SalesOrderDetail
GROUP BY SpecialOfferId
ORDER BY SpecialOfferId

SELECT SpecialOfferId, SUM(UnitPrice) AS 'Soma Unitária'
FROM Sales.SalesOrderDetail
WHERE SpecialOfferId = 9
GROUP BY SpecialOfferId

CREATE PROCEDURE Func
AS
SELECT SpecialOfferId, SUM(UnitPrice) AS 'Soma Unitária'
FROM Sales.SalesOrderDetail
WHERE SpecialOfferId = 9
GROUP BY SpecialOfferId
GO

DROP PROCEDURE Func

EXEC FUNC;

/*CREATE FUNCTION SalesMonth(@mes INT, @ano INT) RETURNS */

SELECT * FROM Sales.SalesOrderDetail

SELECT SalesOrderId, 2014, 6, SUM(OrderQty), AVG(UnitPrice), SUM(UnitPriceDiscount), SUM(LineTotal)
FROM Sales.SalesOrderDetail
WHERE ModifiedDate LIKE '2014/%6/%'
GROUP BY SalesOrderID
