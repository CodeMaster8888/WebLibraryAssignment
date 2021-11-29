using Database.Context;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BookManager : IBookManager
    {
        private readonly IBookContext _bookContext;

        public BookManager(IBookContext bookContext)
        {
            _bookContext = bookContext ?? throw new ArgumentNullException(nameof(bookContext));
        }

        public Book GetBook(int id)
        {
            return _bookContext.GetBook(id);
        }

        public List<Book> GetBooks()
        {
            return _bookContext.GetBooks();
        }

        public void CreateBook(Book book)
        {
            _bookContext.CreateBook(book);
        }
    }
}
