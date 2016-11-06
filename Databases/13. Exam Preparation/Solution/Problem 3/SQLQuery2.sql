SELECT d.Name, COUNT(e.Id) FROM Departments d
INNER JOIN Employees e
on d.Id = e.DepartmentId
GROUP BY d.Name