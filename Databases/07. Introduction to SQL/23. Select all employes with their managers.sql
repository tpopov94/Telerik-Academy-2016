SELECT e.FirstName + ' ' + e.LastName AS [Full Name],
ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager Name]
	FROM Employees e
LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID