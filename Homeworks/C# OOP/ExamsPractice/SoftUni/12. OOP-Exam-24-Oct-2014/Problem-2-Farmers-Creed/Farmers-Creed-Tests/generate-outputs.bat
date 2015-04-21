csc *.cs
FOR %%f in ("*.in.txt") DO (
	SETLOCAL EnableDelayedExpansion
    SET "file=%%f"
    Farm.exe < "%%f" > "!file:.in.txt=.out.txt!"
)
