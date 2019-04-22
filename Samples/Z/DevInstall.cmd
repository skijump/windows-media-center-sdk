@ECHO OFF
ECHO.
ECHO.Usage: Command.InstallAndRegister.cmd [/u][/debug]
ECHO.

set CompanyName=09530D0BE3104237B278FA545F27AA38
set ProductName=Z
set AssemblyName=Z
set RegistrationFilename=Registration.xml
set ImageName=ZLogoProgramLibrary.png
set GACUtilPath=%ProgramFiles%

REM Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86

ECHO.On an x64 machine
set ProgramFilesPath=%ProgramFiles(x86)%
ECHO.

goto unregister

:x86

	ECHO.On an x86 machine
	set ProgramFilesPath=%ProgramFiles%
	ECHO.

:unregister

	ECHO.Unregister and delete previously installed files (which may fail if nothing is registered)
	ECHO.

	ECHO.Unregister the application entry points
	%windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%RegistrationFilename%" /u
	ECHO.

	ECHO.Remove the DLL from the Global Assembly cache
	"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /u "%AssemblyName%"
	ECHO.

	ECHO.Delete the folders containing the DLLs and supporting files (silent if successful)
	rd /s /q "%ProgramFilesPath%\%CompanyName%\%ProductName%"
	rd /s /q "%ProgramFilesPath%\%CompanyName%"
	ECHO.

	ECHO.Delete the InstallLocation registry value
	reg delete "HKLM\Software\%CompanyName%\%ProductName%" /v InstallLocation /f
	ECHO.
	
	ECHO.Delete the ShowLoginPage registry value
	reg delete "HKLM\Software\%CompanyName%\%ProductName%" /v ShowLoginPage /f
	ECHO.
	
	ECHO.Delete the sample content and data
	rd /s /q "%programdata%\%CompanyName%\Z"
	rd /s /q "%programdata%\%CompanyName%"
	del /q "%public%\Videos\Z\*.*"
	rd /s /q "%public%\Videos\Z"
	del /q "%public%\Music\Z\*.*"
	rd /s /q "%public%\Music\Z"

	REM Exit out if the /u uninstall argument is provided, leaving no trace of the program files.
	if "%1"=="/u" goto exit
	
:releasetype

	REM evaluate the second argument
	if "%1"=="/debug" goto debug
	
	ECHO.Using the release version of the binaries
	set ReleaseType=Release
	ECHO.
	
	goto checkbin
	
:debug

	ECHO.Using the Debug version of the binaries
	set ReleaseType=Debug
	ECHO.
	
:checkbin

    if exist ".\bin\%ReleaseType%\%AssemblyName%.dll" goto register
    ECHO.Cannot find %ReleaseType% binaries.
    ECHO.Build solution as %ReleaseType% and run script again. 
    goto exit

:register

	ECHO.Copy the sample content and data.
	md "%programdata%\%CompanyName%\Z\Data"
	md "%programdata%\%CompanyName%\Z\Images"
	md "%public%\Videos\Z"
	md "%public%\Music\Z"

	copy /y "%public%\videos\Windows Media Center SDK\Video04.wmv" "%public%\Videos\Z\Content.Video.1.wmv"
	copy /y ".\content\audio\*.*" "%public%\Music\Z\"
	copy /y ".\content\video\*.*" "%public%\Videos\Z\"
	copy /y ".\content\data\*.xml" "%programdata%\%CompanyName%\Z\Data\"
	copy /y ".\content\images\*.*" "%programdata%\%CompanyName%\Z\images\"

	REM Copying and registering assemblies

	ECHO.Create the path for the binaries and supporting files (silent if successful)
	md "%ProgramFilesPath%\%CompanyName%\%ProductName%"
	ECHO.
	
	ECHO.Copy the assembly to Program Files
	copy /y ".\bin\%ReleaseType%\%AssemblyName%.dll" "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
	
	ECHO.Copy the logo to program files
	copy /y ".\Images\%ImageName%" "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
	ECHO.
	
	ECHO.Copy the registration XML to program files
	copy /y ".\Setup\%RegistrationFilename%" "%ProgramFilesPath%\%CompanyName%\%ProductName%\"
	ECHO.

	ECHO.Register the DLL with the global assembly cache
	"%GACUtilPath%\Microsoft SDKs\Windows\v6.0A\bin\gacutil.exe" /if "%ProgramFilesPath%\%CompanyName%\%ProductName%\%AssemblyName%.dll"
	ECHO.

	ECHO.Register the application with Windows Media Center
	%windir%\ehome\RegisterMCEApp.exe /allusers "%ProgramFilesPath%\%CompanyName%\%ProductName%\%RegistrationFilename%"
	ECHO.

	ECHO.Add the InstallLocation registry value
	reg add "HKLM\Software\%CompanyName%\%ProductName%" /v InstallLocation /t REG_SZ /d "%ProgramFilesPath%\%CompanyName%\%ProductName%\\" /f
	ECHO.
	
	ECHO.Add the ShowLoginPage registry value
	reg add "HKLM\Software\%CompanyName%\%ProductName%" /v ShowLoginPage /t REG_SZ /d "1" /f
	ECHO.
	
	ECHO.Launch the application using its entrypoint
	"C:\windows\ehome\ehshell.exe" "/entrypoint:{11ffb644-572d-4a2f-9a19-38289e8e5466}\{d916397f-491e-4aa9-aabf-c8957e6bba40}"

:exit