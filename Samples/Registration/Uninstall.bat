REM Usage: uninstall.bat
REM @ECHO OFF
%windir%\ehome\RegisterMCEApp.exe Register2.xml /u /allusers
%windir%\ehome\RegisterMCEApp.exe Register.xml /u /allusers