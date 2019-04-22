set CULTURE=en-us

REM Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86

set ProgramFilesPath=%ProgramFiles(x86)%

goto startInstall

:x86

	set ProgramFilesPath=%ProgramFiles%

:startInstall

	pushd "%~dp0"

	SET WIX_BUILD_LOCATION=%ProgramFilesPath%\Windows Installer XML v3\bin
	REM SET APP_INTERMEDIATE_PATH=..\obj\%BUILD_TYPE%
	SET OUTPUTNAME=Setup-%CULTURE%.msi

	REM Cleanup leftover intermediate files

	del /f /q "%APP_INTERMEDIATE_PATH%\*.wixobj"
	del /f /q "%OUTPUTNAME%"

	REM Build the MSI for the setup package

	"%WIX_BUILD_LOCATION%\candle.exe" setup.wxs -out "setup.wixobj"
	"%WIX_BUILD_LOCATION%\light.exe" "setup.wixobj" -cultures:en-US -ext "%ProgramFilesPath%\Windows Installer XML v3\bin\WixUIExtension.dll" -ext "%ProgramFilesPath%\Windows Installer XML v3\bin\WixUtilExtension.dll" -loc setup-en-us.wxl -out "%OUTPUTNAME%"

popd
