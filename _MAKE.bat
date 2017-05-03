@ECHO off
SetLocal EnableDelayedExpansion

ECHO !time:~0,8! Compile BefunCompile

"BefunCompile.exe" generate ^
    --file="processed\*.b93" ^
    --languages="c;cs;py3;py2;java" ^
    --out="compiled\{l}\{f}.{le}" ^
    --format ^
    --gzip ^
    --ss ^
    --sg ^
    --override ^
    --unsafe

PAUSE