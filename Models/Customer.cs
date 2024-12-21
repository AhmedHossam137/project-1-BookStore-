using Microsoft.AspNetCore.Identity;

namespace project__1_BookStore_.Models
{
    public class Customer:IdentityUser
    {
        public string Name { get; set; }
        
        public string Address { get; set; }
        
    }
}
