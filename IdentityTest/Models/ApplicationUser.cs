using Microsoft.AspNetCore.Identity;
namespace IdentityTest.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
