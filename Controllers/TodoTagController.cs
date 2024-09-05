using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    [Route("api/todo/{todoId}/tags")]
    [ApiController]
    public class TodoTagController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<TodoTagDto>> GetTags(int todoId)
        {
            var todo = TodoDataStore.Current.Todos.FirstOrDefault(todo => todo.Id == todoId);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo.Tags);
        }

        [HttpGet("{tagId}")]
        public ActionResult<TodoTagDto> GetTag(int tagId)
        {
            var todo = TodoDataStore.Current.Todos.FirstOrDefault(todo => todo.Id == todoId);

            if (todo == null)
            {
                return NotFound();
            }

            var tag = todo.Tags.FirstOrDefault(tag => tag.Id == tagId);
            if (tag == null)
            {
                return NotFound();
            }

            return Ok(tag);
        }
    }
}