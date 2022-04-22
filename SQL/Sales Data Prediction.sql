
SELECT c.companyname,
MAX(orderdate) LastOrderDate, (DATEADD(DAY, DATEDIFF(DAY, min(orderdate), max(orderdate))/COUNT(c.companyname), max(orderdate))) 			NextPredicateOrder 
FROM Sales.Customers c 
INNER JOIN  Sales.Orders o
ON c.custid = o.custid		
GROUP BY c.companyname
