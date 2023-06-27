using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWebApi.Context;
using UnitTestingWebApi.Model;

namespace XunitTestTodoList
{
    public class DbContextFixture
    {
        internal readonly TodoDbContext _appDbContext;
        public DbContextFixture()
        {
            var applicationDbContextOptions = new DbContextOptionsBuilder<TodoDbContext>().UseInMemoryDatabase("Unittest").Options;

            _appDbContext=new TodoDbContext(applicationDbContextOptions);
            _appDbContext.Add(new Todo() { Id = 1, ItemName = "Item1", IsCompleted = true });
            _appDbContext.Add(new Todo() { Id = 2, ItemName = "Item2", IsCompleted = false });
            _appDbContext.Add(new Todo() { Id = 3, ItemName = "Item3", IsCompleted = true });
            _appDbContext.SaveChanges();
        }

    }
}
