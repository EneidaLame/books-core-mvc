using System;
using System.Collections.Generic;
using System.Linq;
using books.Models;
using Microsoft.EntityFrameworkCore;

namespace TestMVC.Models
{
    public class MySQLContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public MySQLContext(DbContextOptions<MySQLContext> options)
            : base(options) { }
    }
}
