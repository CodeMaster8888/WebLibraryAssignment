using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Context
{
    public interface IBookContext
    {
        void CreateBook(Book book);
        Book GetBook(int bookId);
        List<Book> GetBooks();
    }
}
