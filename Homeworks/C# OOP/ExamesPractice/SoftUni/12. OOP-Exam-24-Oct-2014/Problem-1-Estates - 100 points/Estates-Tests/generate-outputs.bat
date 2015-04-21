csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    Estates.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
del *.exe
PAUSE