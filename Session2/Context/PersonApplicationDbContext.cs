using Microsoft.EntityFrameworkCore;
using Session2.Models;

namespace Session2.Context
{
    public class PersonApplicationDbContext:DbContext
    {
        public PersonApplicationDbContext(DbContextOptions<PersonApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Person>persons { get; set; }
        public DbSet<Session2.Models.PersonVM>? PersonVM { get; set; }
    }
}
