SELECT e.FirstName + ' ' +e.LastName AS [Full Name], a.AddressText 
FROM Employees e, Addresses a WHERE e.AddressID = a.AddressID