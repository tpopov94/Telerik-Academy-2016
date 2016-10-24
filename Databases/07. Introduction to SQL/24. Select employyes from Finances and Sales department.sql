SELECT E.FirstName + ' ' + e.LastName AS [Full Name], d.Name AS [Department], e.HireDate
FROM Employees e 
  JOIN Departments d
    ON d.DepartmentID=e.DepartmentID AND d.Name IN ('Sales','Finance')
WHERE e.HireDate BETWEEN '1995-1-1' AND '2005-1-1'