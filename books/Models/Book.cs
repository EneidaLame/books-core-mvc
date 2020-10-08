using System;
using System.Collections.Generic;
using books.Models;

namespace TestMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }

    }
}
