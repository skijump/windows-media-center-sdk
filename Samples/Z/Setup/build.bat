SET BUILD_TYPE=Release
if "%1" == "Debug" set BUILD_TYPE=Debug

REM Determine whether we are on an 32 or 64 bit machine
if "%PROCESSOR_ARCHITECTURE%"=="x86" if "%PROCESSOR_ARCHITEW6432%"=="" goto x86

set ProgramFilesPath=%ProgramFiles(x86)%

goto startInstall

:x86

set ProgramFilesPath=%ProgramFiles%

:startInstall

SET WIX_BUILD_LOCATION=%ProgramFilesPath%\Windows Installer XML v3\bin
SET Z_SRC_PATH=%ProgramFilesPath%\Microsoft SDKs\Windows Media Center\v6.0\Samples\Z
SET Z_INTERMEDIATE_PATH=%Z_SRC_PATH%\obj\%BUILD_TYPE%
SET OUTPUTNAME=%Z_SRC_PATH%\bin\%BUILD_TYPE%\Z_Sample_Application.msi

REM Cleanup leftover intermediate files

del /f /q "%Z_INTERMEDIATE_PATH%\*.wixobj"
del /f /q "%OUTPUTNAME%"

REM Build the MSI for the setup package

pushd "%Z_SRC_PATH%\Setup"

"%WIX_BUILD_LOCATION%\candle.exe" "%Z_SRC_PATH%\Setup\z.wxs" -dBuildType=%BUILD_TYPE% -ext "%ProgramFilesPath%\Windows Installer XML v3\bin\WixUtilExtension.dll" -out "%Z_INTERMEDIATE_PATH%\z.wixobj"
"%WIX_BUILD_LOCATION%\light.exe" "%Z_INTERMEDIATE_PATH%\z.wixobj" -cultures:en-US -ext "%ProgramFilesPath%\Windows Installer XML v3\bin\WixUIExtension.dll" -ext "%ProgramFilesPath%\Windows Installer XML v3\bin\WixUtilExtension.dll" -loc "%Z_SRC_PATH%\Setup\z_en-us.wxl" -out "%OUTPUTNAME%"

popd
