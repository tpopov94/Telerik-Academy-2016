/* 1 Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
    Use a nested SELECT statement.*/
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees) 
--------------------------------------------------

/* 2 find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.*/
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary <= (SELECT 1.1 * MIN(Salary) from Employees)
--------------------------------------------------

/* 3 find the full name, salary and department of the employees that take the minimal salary in their department. */
SELECT FirstName, LastName, Salary, d.Name FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE Salary = (SELECT MIN(Salary) FROM Employees emp
	WHERE emp.DepartmentID = d.DepartmentID)
	ORDER BY e.Salary
-------------------------------------------------

/* 4 Write a SQL query to find the average salary in the department with id 1 */
SELECT e.DepartmentID,AVG(Salary) as [Average Salary] FROM Employees e 
	JOIN Departments d ON e.DepartmentID=d.DepartmentID
WHERE d.DepartmentID = 1
GROUP BY e.DepartmentID
------------------------------------------------

/* 5 find the average salary in the "Sales" department */
SELECT e.DepartmentID, AVG(Salary) as [Average Salary in Sales] FROM Employees e 
	JOIN Departments d ON e.DepartmentID=d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY e.DepartmentID
-----------------------------------------------

/* 6 find the number of employees in the "Sales" department */
SELECT COUNT(*) as [Number of Employees] FROM Employees e 
	JOIN Departments d ON e.DepartmentID=d.DepartmentID
WHERE d.Name = 'Sales'
-----------------------------------------------

/* 7 number of all employees that have manager*/
SELECT COUNT(*) as [Number of employees] from Employees
WHERE ManagerID IS NOT NULL 
-----------------------------------------------

/* 8 number of all employees that does not have manager*/
SELECT COUNT(*) as [Number of Managers] from Employees
WHERE ManagerID IS NULL 
-----------------------------------------------

/* 9 find the average salary in each department */
SELECT e.DepartmentID, AVG(Salary) as [Average Salary in Sales] FROM Employees e 
	JOIN Departments d ON e.DepartmentID=d.DepartmentID
GROUP BY e.DepartmentID
------------------------------------------------

