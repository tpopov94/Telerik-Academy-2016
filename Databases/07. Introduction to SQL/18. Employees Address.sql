SELECT e.FirstName + ' ' +e.LastName AS [Full Name], a.AddressText, t.Name
FROM Employees e
	JOIN Addresses a
ON e.AddressID = a.AddressID
	JOIN Towns t
On a.TownID = t.TownID
