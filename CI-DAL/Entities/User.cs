using Microsoft.AspNetCore.Identity;

namespace CI_DAL.Entities
{
    public class User : IdentityUser
    {
        public string CompanyName { get; set; }
    }
}