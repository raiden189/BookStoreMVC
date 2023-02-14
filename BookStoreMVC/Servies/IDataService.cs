using BookStoreMVC.Models;

namespace BookStoreMVC.Services
{
    /// <summary>
    /// Books Mocking Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataService<T>
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<bool> AddBookAsync(Book book);
        Task<bool> UpdateBookAsync(Book book);
        Task<bool> DeleteBookAsync(Book book);
    }
}
