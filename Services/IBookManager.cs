using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IBookManager
    {
        void CreateBook(Book book);
        Book GetBook(int id);
        List<Book> GetBooks();
    }
}
