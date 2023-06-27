using Microsoft.EntityFrameworkCore;
using UnitTestingWebApi.Model;

namespace UnitTestingWebApi.Context
{
    public class TodoDbContext:DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
                
        }

        public DbSet<Todo> Todos { get; set; }


    }
}
