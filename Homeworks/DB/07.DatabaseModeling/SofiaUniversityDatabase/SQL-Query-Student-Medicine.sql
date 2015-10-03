SELECT
	st.FirstName + ' ' + st.LastName AS [Student],
	st.FacultyNumber AS [Faculty number],
	f.Name AS [Faculty]
FROM Students st
	JOIN Faculties f
	ON f.Id = st.FacultyId
WHERE f.Name = 'Medicine'
ORDER BY [Student] ASC

