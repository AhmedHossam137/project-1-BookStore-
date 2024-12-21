namespace project__1_BookStore_.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }   // Composite Key, Foreign Key
        public int BookId { get; set; }    // Composite Key, Foreign Key
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
