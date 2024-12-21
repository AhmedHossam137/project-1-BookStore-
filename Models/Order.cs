namespace project__1_BookStore_.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }    // Foreign Key
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
