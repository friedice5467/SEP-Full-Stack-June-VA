--Joins:
--(AdventureWorks)


--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the
--following.

SELECT pcr.Name, psp.Name
FROM Person.CountryRegion AS pcr
JOIN Person.StateProvince AS psp ON psp.CountryRegionCode = pcr.CountryRegionCode




--    Country                        Province




--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.

SELECT pcr.Name, psp.Name
FROM Person.CountryRegion AS pcr
JOIN Person.StateProvince AS psp ON psp.CountryRegionCode = pcr.CountryRegionCode
WHERE pcr.Name = 'Germany' OR pcr.Name = 'Canada'


--    Country                        Province


--3. List all Products that has been sold at least once in last 25 years.

SELECT p.ProductName, o.OrderDate
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
ORDER BY o.OrderDate ASC

 

--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.

SELECT DISTINCT top 5 o.ShipPostalCode, SUM(od.Quantity) AS sold
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY o.ShipPostalCode
ORDER BY sold DESC

--5. List all city names and number of customers in that city.     

SELECT c.City, count(c.ContactName) AS numberOfCustomers, SUM(od.Quantity) AS sold
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY c.City
ORDER BY sold DESC


--6. List city names which have more than 2 customers, and number of customers in that city

SELECT c.City, count(c.ContactName) AS numberOfCustomers, SUM(od.Quantity) AS sold
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY c.City
HAVING count(c.ContactName) > 2
ORDER BY sold DESC


--7. Display the names of all customers  along with the  count of products they bought

SELECT c.ContactName, SUM(od.Quantity) AS sold
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY c.ContactName
ORDER BY sold DESC


--8. Display the customer ids who bought more than 100 Products with count of products.

SELECT c.CustomerID, SUM(od.Quantity) AS sold
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100
ORDER BY sold DESC


--9. List all of the possible ways that suppliers can ship their products. Display the results as below

SELECT DISTINCT sup.CompanyName, ship.CompanyName
FROM Suppliers AS sup
JOIN Products AS p ON p.SupplierID = sup.SupplierID
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Shippers AS ship ON ship.ShipperID = o.ShipVia
ORDER BY sup.CompanyName

--    Supplier Company Name                Shipping Company Name




--    ---------------------------------            ----------------------------------




--10. Display the products order each day. Show Order date and Product Name.

SELECT c.CustomerID, SUM(od.Quantity) AS sold, o.OrderDate, p.ProductName
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1997-6-22' 
GROUP BY c.CustomerID, o.OrderDate, p.ProductName
ORDER BY o.OrderDate DESC, sold DESC


--11. Displays pairs of employees who have the same job title.

SELECT LastName, FirstName, Title
FROM Employees
WHERE Title IN (
SELECT Title 
FROM Employees
GROUP BY Title
HAVING COUNT(*) > 1
)


--12. Display all the Managers who have more than 2 employees reporting to them.

SELECT LastName, FirstName, Title FROM Employees
WHERE EmployeeID IN (
SELECT ReportsTo
FROM Employees)


--13. Display the customers and suppliers by city. The results should have the following columns

SELECT c.City, s.CompanyName, c.ContactName
FROM Customers AS c
JOIN Orders AS o ON o.CustomerID = c.CustomerID
JOIN [Order Details] AS od ON od.OrderID = o.OrderID
JOIN Products AS p ON p.ProductID = od.ProductID
JOIN Suppliers AS s ON s.SupplierID = p.SupplierID



--City


--Name


--Contact Name,


--Type (Customer or Supplier)





--All scenarios are based on Database NORTHWIND.


--14. List all cities that have both Employees and Customers.

SELECT DISTINCT c.City
FROM Customers AS c 
JOIN Orders AS o ON o.CustomerID = c.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
WHERE c.City = e.City


--15. List all cities that have Customers but no Employee.


--a. 
    
-- Use
--sub-query
SELECT DISTINCT c.City
FROM Customers AS c 
JOIN Orders AS o ON o.CustomerID = c.CustomerID
JOIN Employees AS e ON e.EmployeeID = o.EmployeeID
WHERE c.City = e.City

--b. 
    
-- Do
--not use sub-query
SELECT City
FROM Customers
UNION
SELECT City
FROM Employees
ORDER BY City

--16. List all products and their total order quantities throughout all orders.

SELECT *
FROM Products

--17. List all Customer Cities that have at least two customers.



--a. 
    
-- Use
--union
SELECT City
FROM Customers
GROUP BY City
HAVING count(City) > 2
UNION
SELECT City
FROM Employees
ORDER BY City

--b. 
    
-- Use
--sub-query and no union
SELECT *
FROM Customers AS c
WHERE c.City IN (
SELECT c.City
FROM Customers
HAVING count(c.city) >= 2
)

--18. List all Customer Cities that have ordered at least two different kinds of products.

 SELECT City
FROM Customers
UNION
SELECT City
FROM Suppliers
GROUP BY City
HAVING count(DISTINCT City) >= 2
ORDER BY City


--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

 SELECT TOP 5 p.ProductName, SUM(od.Quantity) AS sold, AVG(p.UnitPrice) AS avgPrice, c.City
FROM Products AS p
JOIN [Order Details] AS od ON od.ProductID = p.ProductID
JOIN Orders AS o ON o.OrderID = od.OrderID
JOIN Customers AS c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > dateadd(YEAR,-25, CURRENT_TIMESTAMP)
GROUP BY p.ProductName, c.City
ORDER BY sold DESC


--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--from. (tip: join  sub-query)




--21. How do you remove the duplicates record of a table?
--Find duplicate rows using GROUP BY clause or ROW_NUMBER() function.
--Use DELETE statement to remove the duplicate rows