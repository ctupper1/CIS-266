@ECHO off

:: batch file for
:: Murach's ADO.NET 4 with Visual Basic 2010
:: company: Mike Murach & Associates, Inc.
:: date:    Nov 26, 2010
:: 
:: Uses the SQLCMD utility to run a SQL script that creates
:: the Payables database.

ECHO Attempting to create the Payables database . . . 
sqlcmd -S localhost\SQLExpress -E /i create_payables.sql
ECHO.
ECHO If no error message is shown, then the database was created successfully.
ECHO.
PAUSE