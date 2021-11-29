using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibraryAssignment.Mappers;

namespace WebLibraryAssignment.FrontEndData
{
    public class LibraryController : ControllerBase
    {
        private readonly IBookManager _bookManager;

        public LibraryController(IBookManager bookManager)
        {
            _bookManager = bookManager ?? throw new ArgumentNullException(nameof(bookManager));
        }

        // GET: LibraryController/Details/5
        public Book Get(int id)
        {
            var book = _bookManager.GetBook(id).BookToFrontEndMap();

            return book;
        }

        // GET: LibraryController/Create
        public List<Book> GetAll()
        {
            List<Book> frontEndBooks = new List<Book>();
            var books = _bookManager.GetBooks();

            books.ForEach(x =>
            {
                frontEndBooks.Add(x.BookToFrontEndMap());
            });

            return frontEndBooks;
        }

        public void Create(Book book)
        {
            var frontEndBook = book.FrontEndToBookMap();
            _bookManager.CreateBook(frontEndBook);
        }

        public List<Book> SortBooks(int sort)
        {
            var sortbooks = GetAll();

            sortbooks.Sort(delegate(Book b1, Book b2)
            {
                return b1.Title.CompareTo(b2.Title);
            });

            return sortbooks;
        }

        //// GET: LibraryController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: LibraryController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: LibraryController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: LibraryController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
