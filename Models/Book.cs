namespace project__1_BookStore_.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }      // Foreign Key
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime PublishDate { get; set; }
        public int CatalogId { get; set; }     // Foreign Key

        // Navigation Properties
        public Author Author { get; set; }
        public Catalog Catalog { get; set; }

        // Books can be part of many orders
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
