using Microsoft.EntityFrameworkCore;
using UnitTestingWebApi.Context;
using UnitTestingWebApi.Model;

namespace UnitTestingWebApi.Service
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _context;
        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Todo>> GetAllAsync()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task SaveAsync(Todo newTodo)
        {
            _context.Todos.Add(newTodo);
            await _context.SaveChangesAsync();
        }
    }
}
