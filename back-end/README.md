## Update the database
1. Run the following SQL query:
```
USE MASTER
GO
DROP DATABASE IF EXISTS [WebelopersDB]; CREATE DATABASE [WebelopersDB]
GO
```
2. `cd Org.Webelopers.API` (if you are in the `back-end` directory)
3. Run from the nuGet package console: ```dotnet ef database update'```


## Login Accounts JSON
```
{
  "email": "test{numar}@test.com",
  "password": "defaultpassword"
}
```