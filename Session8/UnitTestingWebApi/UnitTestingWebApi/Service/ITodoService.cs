using UnitTestingWebApi.Model;

namespace UnitTestingWebApi.Service
{
    public interface ITodoService
    {
        Task<List<Todo>> GetAllAsync();
        Task SaveAsync(Todo newTodo);
    }
}
