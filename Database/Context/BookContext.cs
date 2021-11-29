using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Context
{
    public class BookContext : IBookContext
    {
        private readonly LibraryContext _libraryContext;

        public BookContext(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext ?? throw new ArgumentNullException(nameof(libraryContext));
        }

        public Book GetBook(int bookId)
        {
            return _libraryContext.Books.SingleOrDefault(x => x.Id == bookId);
        }

        public List<Book> GetBooks()
        {
            return _libraryContext.Books.Select(x => x).ToList();
        }

        public void CreateBook(Book book)
        {
            _libraryContext.Add(book);
            _libraryContext.SaveChanges();
        }
    }
}
