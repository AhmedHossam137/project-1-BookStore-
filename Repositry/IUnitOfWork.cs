using project__1_BookStore_.Models;

namespace project__1_BookStore_.Repositry
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> Books { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Author> Authors { get; }
        Task<int> SaveAsync();  // Commit changes to the database
    }
}
