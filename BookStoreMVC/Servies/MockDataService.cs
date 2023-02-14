using BookStoreMVC.Models;

namespace BookStoreMVC.Services
{
    /// <summary>
    /// Mocking Books Data
    /// </summary>
    public class MockDataService : IDataService<Book>
    {
        readonly List<Book> books;
        public MockDataService()
        {
            books = new List<Book>()
            {
                new Book{ BookId = "9b0896fa-3880-4c2e-bfd6-925c87f22878", BookName = "CQRS for Dummies" },
                new Book{ BookId = "0550818d-36ad-4a8d-9c3a-a715bf15de76", BookName = "Visual Studio Tips" },
                new Book{ BookId = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1", BookName = "NHibernate Cookbook" }
            };
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await Task.FromResult(books);
        }

        public async Task<bool> AddBookAsync(Book book)
        {
            books.Add(book);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateBookAsync(Book book)
        {
            var oldBook = books.Where((Book bkArg) => bkArg.BookId == book.BookId).FirstOrDefault();
            books.Remove(oldBook);
            books.Add(book);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteBookAsync(Book book)
        {
            var oldBook = books.Where((Book bkArg) => bkArg.BookId == book.BookId).FirstOrDefault();
            books.Remove(oldBook);

            return await Task.FromResult(true);
        }
    }
}
