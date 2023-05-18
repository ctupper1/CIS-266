@ECHO off

:: batch file for
:: Murach's ASP.NET 3.5 Web Programming with VB 2008
:: company: Mike Murach & Associates, Inc.
:: date:    June 13, 2008
:: 
:: Uses SQLCMD utility to run a SQL script that grants
:: ASP.NET access to the Payables database.

ECHO Attempting to grant ASP.NET access to the Payables database . . . 
sqlcmd -S localhost\SQLExpress -E /i grant_access_windows_7_vista.sql
ECHO.
ECHO If no error message is shown, then access has been granted to the database.
ECHO.
PAUSE
