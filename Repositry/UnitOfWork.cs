using project__1_BookStore_.Models;

namespace project__1_BookStore_.Repositry
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreContext _context;
        private IGenericRepository<Book> _books;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OrderItem> _orderItems;
        private IGenericRepository<Author> _authors;

        public UnitOfWork(BookStoreContext context)
        {
            _context = context;
        }

        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);
        public IGenericRepository<Order> Orders => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<OrderItem> OrderItems => _orderItems ??= new GenericRepository<OrderItem>(_context);
        public IGenericRepository<Author> Authors => _authors ??= new GenericRepository<Author>(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
