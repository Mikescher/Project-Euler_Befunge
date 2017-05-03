[Project Euler](https://projecteuler.net/) with [Befunge 93](http://esolangs.org/wiki/Befunge)
===========================================================

These are the Befunge programs from the /processed folder compiled with **[BefunCompile](https://github.com/Mikescher/BefunCompile)**.

[BefunCompile](https://github.com/Mikescher/BefunCompile) is my own non-general Befunge to C / C# / Python compiler.  
These files are not always up to date - if you want to be sure better compile them again yourself:

Here is the command used to create these files:
~~~
"PATH\TO\BefunCompile.exe" generate ^
    --file="processed\*.b93" ^
    --languages="c;cs;py3;py2;java" ^
    --out="compiled\{l}\{f}.{le}" ^
    --format ^
    --gzip ^
    --ss ^
    --sg ^
    --override ^
    --unsafe
~~~