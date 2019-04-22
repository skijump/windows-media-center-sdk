@ECHO OFF
ECHO.Usage: DevInstall.cmd [/u][/debug]
ECHO.This script requires Administrative privileges to run properly.
ECHO.Start > All Programs > Accessories> Right-Click Command Prompt > Select 'Run As Administrator'
 
set CompanyName=MyCompany
set AssemblyName=$safeprojectname$
set RegistrationName=Registration
set GACUtilPath=%ProgramFiles%
 
ECHO.Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86
set ProgramFilesPath=%ProgramFiles(x86)%
 
goto unregister
 
:x86

    ECHO.On an x86 machine
    set ProgramFilesPath=%ProgramFiles%

:unregister

    ECHO.*** Unregistering and deleting assemblies ***

    ECHO.Unregister and delete previously installed files (which may fail if nothing is registered)

    ECHO.Unregister the application entry points
    %windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%AssemblyName%\%RegistrationName%.xml" /u

    ECHO.Remove the DLL from the Global Assembly cache
    "%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /u "%AssemblyName%"

    ECHO.Delete the folder containing the DLLs and supporting files (silent if successful)
    rd /s /q "%ProgramFilesPath%\%CompanyName%\%AssemblyName%"

    REM Exit out if the /u uninstall argument is provided, leaving no trace of program files.
    if "%1"=="/u" goto exit
                
:releasetype
 
    if "%1"=="/debug" goto debug
    set ReleaseType=Release
    goto checkbin
                
:debug
    set ReleaseType=Debug
                
:checkbin
 
    if exist ".\bin\%ReleaseType%\%AssemblyName%.dll" goto register
    ECHO.Cannot find %ReleaseType% binaries.
    ECHO.Build solution as %ReleaseType% and run script again. 
    goto exit
                
:register

    ECHO.*** Copying and registering assemblies ***

    ECHO.Create the path for the binaries and supporting files (silent if successful)
    md "%ProgramFilesPath%\%CompanyName%\%AssemblyName%"
    
    ECHO.Copy the binaries to program files
    copy /y ".\bin\%ReleaseType%\%AssemblyName%.dll" "%ProgramFilesPath%\%CompanyName%\%AssemblyName%\"
    
    ECHO.Copy the registration XML to program files
    copy /y ".\Setup\%RegistrationName%.xml" "%ProgramFilesPath%\%CompanyName%\%AssemblyName%\"

    ECHO.Register the DLL with the global assembly cache
    "%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /if "%ProgramFilesPath%\%CompanyName%\%AssemblyName%\%AssemblyName%.dll"

    ECHO.Register the application with Windows Media Center
    %windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%AssemblyName%\%RegistrationName%.xml"

:exit