SELECT Countries.Name AS [Country], Cities.Name AS [Capital]
FROM Countries, Cities
WHERE Countries.Capital = Cities.Id