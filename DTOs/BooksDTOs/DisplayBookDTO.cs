using System.Text.Json.Serialization;

namespace project__1_BookStore_.DTOs.BooksDTOs
{
    public class DisplayBookDTO
    {
        public int id { get; set; }

        public string title { get; set; }

        [JsonIgnore]
        public decimal price { get; set; }
        public int stock { get; set; }

        public DateOnly publishdate { get; set; }

        public string authorname { get; set; }
        public string catalog { get; set; }
    }
}
