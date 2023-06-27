using Microsoft.AspNetCore.Identity;

namespace CourseAppWebApi.Context
{
    public class APIUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
