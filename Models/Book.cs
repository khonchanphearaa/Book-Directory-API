using System;
namespace BooksDirectoryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Author_Id { get; set; }
        public int Genre_Id { get; set; }
    }
}

