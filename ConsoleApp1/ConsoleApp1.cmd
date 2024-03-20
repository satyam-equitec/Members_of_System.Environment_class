@echo off
rem A batch file for ConsoleApp1.exe

dotnet run
@if "%ERRORLEVEL%" == "0" goto success

:fail
  echo This Application failed!
  echo return value = %ERRORLEVEL%
  goto end
:success
   echo This Application Passed!
   echo return value = %ERRORLEVEL%
   goto end
:end 
echo all done!