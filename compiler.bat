@echo off
title chidraqul compiler (needs csc.exe in path variable)
:compile
cls
echo ==== building chidraqul with csc.exe ====
csc /t:exe /out:chidraqul.exe chidraqul.cs 
echo === done (press any key to compile agian) ===
pause >NUL
goto compile