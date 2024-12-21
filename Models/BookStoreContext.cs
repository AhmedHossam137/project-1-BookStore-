using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project__1_BookStore_.Models;

public class BookStoreContext : IdentityDbContext
{
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }


    public BookStoreContext(DbContextOptions<BookStoreContext> option) : base(option)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite key: OrderId + BookId
        modelBuilder.Entity<OrderItem>()
            .HasKey(oi => new { oi.OrderId, oi.BookId });

        // Define foreign key relationships
        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Book)
            .WithMany(b => b.OrderItems)
            .HasForeignKey(oi => oi.BookId);

        base.OnModelCreating(modelBuilder);
    }
}
