SELECT e.FirstName + ' ' +e.LastName AS [Employee Full Name],m.FirstName + ' ' +m.LAStName AS [Manager Full Name]
FROM Employees e
	JOIN Employees m 
ON e.ManagerID=m.EmployeeID