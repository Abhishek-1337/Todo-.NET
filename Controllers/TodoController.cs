using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet("todo")]
        public ActionResult<IEnumerable<TodoDto>> GetTodos()
        {
            return Ok(TodoDataStore.Current.Todos);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoDto> GetTodo(int id)
        {
            var todo = TodoDataStore.Current.Todos.FirstOrDefault(todo => todo.Id == id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);
        }
    }
}