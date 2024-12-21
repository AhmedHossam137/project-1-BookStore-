namespace project__1_BookStore_.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public int Age { get; set; }
        public int NumberOfBooks { get; set; }

        // Navigation Property: Books written by the Author
        public ICollection<Book> Books { get; set; }
    }
}
