@ECHO OFF
ECHO.
ECHO.Usage: DevInstall.cmd [/u]
ECHO.
ECHO.This script requires Administrative privileges to run properly.
ECHO.Start > All Programs > Accessories> Right-Click Command Prompt > Select 'Run As Administrator'
ECHO.

set CompanyName=Microsoft
set ProductName=M
set ManagedAssemblyName=iTvApp
set NativeAssemblyName=DataReceiver
set InteropAssemblyName=AddinDataReceiver
set RegistrationFileName=iTvAppRegistration
set ReleaseType=Release
set GACUtilPath=%ProgramFiles%
set ProgramFilesPath=%ProgramFiles%

REM ---------------------- START ACTIONS ----------------------

REM Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="AMD64" set ProgramFilesPath=%ProgramFiles(x86)%

REM ---------------------- UNREGISTERING COMPONENTS ----------------------
	
:unregister

ECHO.*** Unregistering and deleting assemblies ***
ECHO.

ECHO.Unregister and delete previously installed files (which may fail if nothing is registered)
ECHO.

ECHO.Unregister the application entry points
if exist "%ProgramFilesPath%\%CompanyName%\%ProductName%\%RegistrationFilename%.xml" ( %windir%\ehome\RegisterMCEApp.exe /u /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%RegistrationFileName%.xml" )  
ECHO.

ECHO.Remove the DLL from the Global Assembly cache
"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /u "%ManagedAssemblyName%"
"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /u "%InteropAssemblyName%"
ECHO.   

ECHO.Unregister the %NativeAssemblyName% DLL
if exist "%ProgramFilesPath%\%CompanyName%\%ProductName%\%NativeAssemblyName%.dll" ( regsvr32 /s /u "%ProgramFilesPath%\%CompanyName%\%ProductName%\%NativeAssemblyName%.dll"
																					 if errorlevel 3 ( ECHO.Unregistering %NativeAssemblyName% failed goto continueuninstall) 
																					 ECHO.Unregistering %NativeAssemblyName% succeeded )

:continueuninstall																					 
ECHO.    

ECHO.Remove the directory that contains the %ProductName% assemblies  
rd /s /q "%ProgramFilesPath%\%CompanyName%\%ProductName%"

if "%1"=="/u" ( goto exit )

REM ---------------------- CHECK PLATFORM ----------------------

ECHO.
ECHO.Check if we have the required binaries
 
    if exist ".\bin\%ReleaseType%\%ManagedAssemblyName%.dll" ( if exist ".\bin\%ReleaseType%\%InteropAssemblyName%.dll" ( if exist "..\DataReceiver\%ReleaseType%\%NativeAssemblyName%.dll" (goto register) ) )    
    ECHO.Cannot find one or more %ReleaseType% binaries.
    ECHO.Build solution as %ReleaseType% and run script again. 
    goto exit

REM ---------------------- REGISTERING COMPONENTS ----------------------

:register

ECHO.
ECHO.All %ReleaseType% binaries are available
ECHO.*** Registering assemblies ***
ECHO.

ECHO.Create a directory for %ProductName% assemblies
ECHO.

if not exist "%ProgramFilesPath%\%CompanyName%\%ProductName%" ( md "%ProgramFilesPath%\%CompanyName%\%ProductName%" ) 
    
    ECHO.Copy the DLLs to the "%ProgramFilesPath%\%CompanyName%\%ProductName%" directory
    copy /y .\bin\%ReleaseType%\%ManagedAssemblyName%.dll "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
    copy /y .\bin\%ReleaseType%\%InteropAssemblyName%.dll "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
    copy /y ..\DataReceiver\%ReleaseType%\%NativeAssemblyName%.dll "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
    copy /y %RegistrationFileName%.xml "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
    ECHO.
        
    ECHO.Register the application with Windows Media Center
    %windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%RegistrationFileName%.xml"
    ECHO.
    
    ECHO.Register the %NativeAssemblyName% DLL
    regsvr32 /s "%ProgramFilesPath%\%CompanyName%\%ProductName%\%NativeAssemblyName%.dll" if errorlevel 3 ( ECHO. Registering %NativeAssemblyName% failed goto exit)   
    ECHO.Registering %NativeAssemblyName% succeeded
    ECHO.    
    
    ECHO.Register the DLL with the global assembly cache
	"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /if "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ManagedAssemblyName%.dll"
	"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /if "%ProgramFilesPath%\%CompanyName%\%ProductName%\%InteropAssemblyName%.dll"
	ECHO.
	
	ECHO.Registration completed successfully
	ECHO.

REM ---------------------- EXIT ----------------------

:exit