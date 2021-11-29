using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        public LibraryContext()
        {
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
