using System;
using System.Collections.Generic;

namespace TestMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public static List<Book> getBooks()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book(1, "The C Programming Language"));
            books.Add(new Book(2, "C++ Bible"));

            return books;
        }

    }
}
