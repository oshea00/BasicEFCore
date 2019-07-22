# Basic Console EFCore

This project is enough to insure the development environment is working properly for EF Core development in macOS.
Although, this should work on Windows or Linux if you are using Docker.

## Setup on macOS

1. Install docker sql server container

>docker pull microsoft/mssql-server-linux
>docker run -d --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrong1Pwd' -p 1433:1433 microsoft/mssql-server-linux

CLI install:
>sudo install -g sql-cli

run mssql:
mssql -u sa -p reallyStrong1Pwd

## Setup Database

1. Edit connection string in Program.cs DemoContext to math your settings from above.
Navigate command line to SqlOsx project directory.

2. Run migrations and create inital database
>dotnet ef database update

3. To add migrations after Model changes and update database.
>dotnet ef migrations add <new migration name>
>dotnet ef database update

See dotnet [CLI EF Core Commands Reference](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell))




