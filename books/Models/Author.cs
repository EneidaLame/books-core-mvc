using System;
using System.Collections.Generic;
using TestMVC.Models;

namespace books.Models
{
    public class Author
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
