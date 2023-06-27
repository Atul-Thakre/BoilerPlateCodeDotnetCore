using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestingWebApi.Model;
using UnitTestingWebApi.Service;

namespace UnitTestingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
       

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        

        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _todoService.GetAllAsync();
            if (result.Count == 0)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> SaveAsync(Todo newTodo)
        {
            await _todoService.SaveAsync(newTodo);
            return Ok();
        }


    }
}
