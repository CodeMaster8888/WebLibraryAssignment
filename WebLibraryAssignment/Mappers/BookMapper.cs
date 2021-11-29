using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibraryAssignment.Mappers
{
    public static class BookMapper
    {
        public static FrontEndData.Book BookToFrontEndMap<T>(this T dataBook) where T : Book
        {
            FrontEndData.Book frontEndbook = new FrontEndData.Book()
            {
                Id = dataBook.Id,
                Author = dataBook.Author,
                Genre = dataBook.Genre,
                Stock = dataBook.Stock,
                Title = dataBook.Title,
                Description = dataBook.Description
            };

            return frontEndbook;
        }

        public static Book FrontEndToBookMap<T>(this T dataBook) where T : FrontEndData.Book
        {
            Book book = new Book()
            {
                Id = dataBook.Id,
                Author = dataBook.Author,
                Genre = dataBook.Genre,
                Stock = dataBook.Stock,
                Title = dataBook.Title,
                Description = dataBook.Description
            };

            return book;
        }
    }
}
