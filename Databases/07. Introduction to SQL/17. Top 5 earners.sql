SELECT FirstName + ' ' + LastName AS [Full Name], Salary
FROM (SELECT TOP 5 Salary, FirstName, LAStName FROM Employees) e
ORDER BY Salary DESC