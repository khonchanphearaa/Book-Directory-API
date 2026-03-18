# BooksDirectoryAPI

Sample applicaitons that provides console applications handle base on API Server.for ```Books Directory API```
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

## How to Get start

