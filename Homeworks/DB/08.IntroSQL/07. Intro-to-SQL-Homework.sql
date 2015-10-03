-- 04. Query to find: All information about all departments
SELECT *
FROM [TelerikAcademy].[dbo].[Departments]


-- 05. Query to find: All department names
SELECT d.Name
FROM [TelerikAcademy].[dbo].[Departments] d


-- 06. Query to find: The salary of each employee
SELECT e.FirstName + ' ' + e.LastName AS [Employee], e.Salary AS [Salary per year]
FROM [TelerikAcademy].[dbo].[Employees] e
ORDER BY [Employee] ASC
-- ORDER BY e.Salary DESC


-- 07. Query to find: The full name of each employee
SELECT e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName AS [Full name]
FROM [TelerikAcademy].[dbo].[Employees] e
ORDER BY [Full name] ASC


-- 08. Query to find: The email addresses of each employee
SELECT
	e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName AS [Full name],
	e.FirstName + '.' + e.LastName + '@telerik.com' AS [Full Email Addresses]
FROM [TelerikAcademy].[dbo].[Employees] e
ORDER BY [Full name] ASC


-- 09. Query to find: All different employee salaries
SELECT DISTINCT e.Salary
FROM [TelerikAcademy].[dbo].[Employees] e


-- 10. Query to find: All information about the employees whose job title is “Sales Representative“
SELECT *
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.JobTitle = 'Sales Representative'


-- 11. Query to find: The names of all employees whose first name starts with "SA".
SELECT
	e.FirstName  AS [First Name],
	ISNULL(e.MiddleName, '') AS [Middle Name],
	e.LastName  AS [Last Name],
	e.FirstName + ' ' + ISNULL(e.MiddleName + '.', '') + ' ' + e.LastName AS [Full name]
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.FirstName LIKE 'SA%'


-- 12. Query to find: The names of all employees whose last name contains "ei".
SELECT
	e.FirstName  AS [First Name],
	ISNULL(e.MiddleName, '') AS [Middle Name],
	e.LastName  AS [Last Name],
	e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName AS [Full name]
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.LastName LIKE '%ei%'


-- 13. Query to find: The salary of all employees whose salary is in the range [20000…30000].
SELECT
	e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName AS [Employee],
	e.Salary
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.Salary BETWEEN 20000 AND 30000
ORDER BY e.Salary ASC, [Employee] ASC


-- 14. Query to find: The names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT e.FirstName, e.LastName, e.Salary
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.Salary IN (25000, 14000, 12500, 23600)
ORDER BY
	e.Salary ASC, 
	e.FirstName ASC, 
	e.LastName ASC

-- 15. Query to find: All employees that do not have manager.
SELECT e.FirstName, e.LastName, e.JobTitle
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.ManagerID IS NULL


-- 16. Query to find: All employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT e.FirstName, e.LastName, e.Salary
FROM [TelerikAcademy].[dbo].[Employees] e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC


-- 17. Query to find: The top 5 best paid employees.
SELECT TOP 5 e.FirstName, e.LastName, e.Salary
FROM [TelerikAcademy].[dbo].[Employees] e
ORDER BY e.Salary DESC


-- 18. Query to find: All employees along with their address. Use inner join with ON clause.
SELECT
	e.FirstName + ' ' + e.LastName AS [Full Name],
	a.AddressText
FROM [TelerikAcademy].[dbo].[Employees] e
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
		ON e.AddressID = a.AddressID
ORDER BY [Full Name]


-- 19. Query to find: All employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT
	e.FirstName + ' ' + e.LastName AS [Full Name],
	a.AddressText
FROM
	[TelerikAcademy].[dbo].[Employees] e,
	[TelerikAcademy].[dbo].[Addresses] a
WHERE e.AddressID = a.AddressID
ORDER BY [Full Name]


-- 20. Query to find: All employees along with their manager.
SELECT
	e.FirstName + ' ' + e.LastName AS [Employee],
	ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] e
	LEFT JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID


-- 21. Query to find: All employees, along with their manager and their address. 
SELECT 
	e.FirstName + ' ' + e.LastName AS [Employee],
	a.AddressText AS [Addresses],
	ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] e
	LEFT JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
	ON e.AddressID = a.AddressID
ORDER BY [Employee] ASC


-- 22. Query to find: All departments and all town names as a single list. Use UNION.
SELECT d.Name
FROM [TelerikAcademy].[dbo].[Departments] d
UNION
SELECT t.Name
FROM [TelerikAcademy].[dbo].[Towns] t


-- 23. Query to find: All the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT
	e.FirstName + ' ' + e.LastName AS [Employee],
	ISNULL(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] e
	LEFT JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID

-- 23. Second edition
SELECT
	ISNULL(e.FirstName + ' ' + e.LastName, 'No employees') AS [Employee],
	m.FirstName + ' ' + m.LastName AS [Manager]
FROM [TelerikAcademy].[dbo].[Employees] e
	RIGHT JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
ORDER BY ISNULL(e.FirstName + ' ' + e.LastName, 'No employees')


-- 24. Query to find: The names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT *
FROM [TelerikAcademy].[dbo].[Employees] e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID AND d.Name IN ('Sales', 'Finance')
WHERE e.HireDate BETWEEN '1995-01-01' AND '2005-12-31'
ORDER BY e.HireDate
