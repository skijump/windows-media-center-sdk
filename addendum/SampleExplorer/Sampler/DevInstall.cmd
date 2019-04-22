@ECHO Off
ECHO.
ECHO.Usage: DevInstall.cmd [/u][/debug]
ECHO.
ECHO.This script requires Administrative privileges to run properly.
ECHO.Start > All Programs > Accessories> Right-Click Command Prompt > Select 'Run As Administrator'
ECHO.

set CompanyName=Microsoft SDKs
set ProductName=Windows Media Center SDK
set ProductVersion=v6.0
set FolderName=Tools
set AssemblyName=Sampler
set RegistrationName=SamplerRegistration
set ProgramImage=Sampler.png
set GacUtilPath="%ProgramFiles%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe"

ECHO.Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86
set ProgramFilesPath=%ProgramFiles(x86)%
ECHO.
 
goto unregister
 
:x86

    ECHO.On an x86 machine
    set ProgramFilesPath=%ProgramFiles%
    ECHO.

:unregister

    ECHO.*** Unregistering and deleting assemblies ***
    ECHO.

    ECHO.Unregister and delete previously installed files
    ECHO.This may fail if nothing is registered which
    ECHO.can occur the first time you run this script.
    ECHO.

    ECHO.Unregister the application entry points
    %windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\%RegistrationName%.xml" /u
    ECHO.

    ECHO.Remove the DLL from the Global Assembly cache
    %GacUtilPath% /u "%AssemblyName%"
    ECHO.

    ECHO.Delete the folder containing the DLLs and supporting files (silent if successful)
    rd /s /q "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%"
    rd /s /q "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%"
    rd /s /q "%ProgramFilesPath%\%CompanyName%\%ProductName%"
    ECHO.

    REM Exit out if the /u uninstall argument is provided, leaving no trace of program files.
    if "%1"=="/u" goto exit
                
:releasetype
 
    if "%1"=="/debug" goto debug
    set ReleaseType=Release
    ECHO.
    goto checkbin
                
:debug
    set ReleaseType=Debug
    ECHO.
                
:checkbin
 
    if exist ".\bin\%ReleaseType%\%AssemblyName%.dll" goto register
    ECHO.*** Cannot find %ReleaseType% binaries: Build solution as %ReleaseType% and run script again. ***
    goto exit
                
:register

    ECHO.*** Copying and registering assemblies ***
    ECHO.

    ECHO.Create the path for the binaries and supporting files (silent if successful)
    md "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%"
    ECHO.
    
    ECHO.Copy the binaries to program files
    copy /y ".\bin\%ReleaseType%\%AssemblyName%.dll" "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\"
    ECHO.
    
    ECHO.Copy the registration XML to program files
    copy /y ".\%RegistrationName%.xml" "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\"
    ECHO.
    
    REM ECHO.Copy the program image to program files
    copy /y ".\%ProgramImage%" "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\"
    REM ECHO.

    ECHO.Register the DLL with the global assembly cache
    %GacUtilPath% /if "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\%AssemblyName%.dll"
    ECHO.

    ECHO.Register the application with Windows Media Center
    %windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%ProductVersion%\%FolderName%\%RegistrationName%.xml"
    ECHO.
    
:CopyContent

	ECHO.Copy content and set registry keys necessary for the
	ECHO.SamplerAddin to run properly and so edits can be made
	ECHO. without having the SDK installed.
	ECHO.Audio
	xcopy /y "..\Sampler\*.mp3" "c:\users\public\music\Windows Media Center SDK\"
	ECHO.Video
	xcopy /y "..\Sampler\*.wmv" "c:\users\public\videos\Windows Media Center SDK\"
	ECHO.Pictures
	xcopy /y "..\Sampler\Photo*.jpg" "c:\users\public\pictures\Windows Media Center SDK\"
	xcopy /y "..\Sampler\Photo*.png" "c:\users\public\pictures\Windows Media Center SDK\"
	ECHO.Schema for Intellisense
	xcopy /y "..\..\Tools\Schemas\*.xsd" "%ProgramFilesPath%\Microsoft Visual Studio 9.0\Xml\Schemas\"
	ECHO.Enable error details
	regedit /s "..\..\Tools\RegFiles\EnableErrorDetails_True.reg"
	ECHO.Point to an installation folder for sampler loose files
	ECHO.Important for the Sample Explorer (Standalone) to work properly.
	ECHO.Note: The SDK setup normally creates this reg key.
	regedit /s DevInstallationFolder.reg
	ECHO.
	ECHO.Copy MCMLPad to [windir]\ehome\ folder
	xcopy "..\..\..\mcmlpad.exe" "%windir%\ehome\" /y
	xcopy "..\..\..\mcmlpad.xml" "%windir%\ehome\" /y
	xcopy "..\..\..\mcmlpad.png" "%windir%\ehome\" /y
	%windir%\ehome\RegisterMCEApp.exe /allusers "%windir%\ehome\mcmlpad.xml"
	
	"C:\windows\ehome\ehshell.exe" "/entrypoint:{bce681ec-a838-4bf3-a124-97674b74851b}\{7f1e2adf-5006-44fb-8f3d-095e635ab443}"

:exit