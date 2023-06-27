using UnitTestingWebApi.Model;
using UnitTestingWebApi.Service;
using Xunit;

namespace XunitTestTodoList
{
    public class UnitTest1:IClassFixture<DbContextFixture>
    {
        readonly TodoService _todoService;

        public UnitTest1(DbContextFixture dbContextFixture)
        {
            _todoService = new TodoService(dbContextFixture._appDbContext);
        }

        [Fact]
        public async void Test1Async()
        {
            //assign
            string ExpectedName = "Item2";

            //act
            List<Todo> todos = await _todoService.GetAllAsync();

            //assert

            Assert.Equal(ExpectedName, todos[1].ItemName);

        }
    }
}