# BooksDirectoryAPI

Sample applicaitons that provides console applications handle base on API Server. for ```Books Directory API```
for RESTful api

Requriments:
- .NET 7.0
- Dapper (Micro ORM)
- MySQL
- Postman (API testing)

** NOTE: Swagger (API Testing) is not aviables

Include manage a library of Books.
- Books
- Author
- Geners

## Features
- Manage Books (CRUD)
- Manage Authors (CRUD)
- Manage Genres (CRUD)
- Relationship: Book → Author → Genre
- Fast data access using Dapper
- Clean Architecture (Controller → Service → Repository)
- Reusable and maintainable code
- Standard API Response format

### Database Design MySQL
```bash
CREATE TABLE authors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE genres (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author_id INT,
    genre_id INT,
    FOREIGN KEY (author_id) REFERENCES authors(id),
    FOREIGN KEY (genre_id) REFERENCES genres(id)
);
```

## How to Get started
Clone the repository and install dependencies
```bash
git clone https://github.com/yourusername/BooksDirectoryAPI.git
cd BooksDirectoryAPI
```

Restore NuGet packages auto
```bash
dontent restore
```

This reads the .csproj file and downloads all required packages:
- Dapper
- MySqlConnector
- Swashbuckle.AspNetCore
- Microsoft.Bcl.AsyncInterfaces
- Microsoft.AspNetCore.OpenApi

Build project
```bash
dotnet build
```

Setup connection with mysql, configurations ```applications.json```

```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=books_db;user=root;password=yourpassword;"
  }
}
```

Running project cli

```bash
dotnet run
```

Optional: Use Automatically reloads changes
```bash
dotnet watch run
```

Check Install Package
```bash
dotnet list package
```
package references:
```bash
Project 'BooksDirectoryAPI' has the following package references
   [net7.0]:
   Top-level Package                    Requested   Resolved
   > Dapper                             2.0.123     2.0.123
   > Microsoft.AspNetCore.OpenApi       7.0.20      7.0.20
   > Microsoft.Bcl.AsyncInterfaces      7.0.0       7.0.0
   > MySqlConnector                     2.5.0       2.5.0
   > Swashbuckle.AspNetCore             6.5.0       6.5.0
```

### API Endpoint

- Books
CRUD: /api/books/:id

- Author
GET/POST: /api/authors

- Genres
GET/POST: /api/genres


### Package installed in proejct BooksDirectoryAPI
Install package
```bash
dotnet add package MySqlConnector
dotnet add package Dapper
```
- MysqlController → ADO.NET driver for .NET 7 Enables connection from your API to MySQL database.
- Dapper → lightweight ORM (fast + clean)

#### Note Warning, Not an error
If the version .NET 7.0 is don't supproted:About the Warning (IMPORTANT but not blocking)

- Option 1:
install package
```bash
Microsoft.Bcl.AsyncInterfaces 9.0.1 doesn't support net7.0
```

- Option 2: ignore warning
Edit: .csproj
```bash
<PropertyGroup>
  <SuppressTfmSupportBuildWarnings>true</SuppressTfmSupportBuildWarnings>
</PropertyGroup>
```

- Option 3: Future upgrade
```bash
<TargetFramework>net8.0</TargetFramework>
```





