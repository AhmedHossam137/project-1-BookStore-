namespace project__1_BookStore_.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Property: Books under this Catalog
        public ICollection<Book> Books { get; set; }
    }
}
