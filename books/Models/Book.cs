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

    }
}
