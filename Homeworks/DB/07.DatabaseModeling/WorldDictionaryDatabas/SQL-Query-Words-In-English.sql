SELECT
	w.WordName AS [Word],
	l.LanguageName AS [Language],
	ex.ExplanationText AS [Explanation]
FROM
	Words w,
	Languages l,
	Explanations ex
WHERE
	w.LanguageID = l.LanguageID AND
	l.LanguageName = 'English' AND
	w.WordID = ex.WordID