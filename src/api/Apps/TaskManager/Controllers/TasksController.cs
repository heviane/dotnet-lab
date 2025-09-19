using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

// Cria um alias para o modelo Task para evitar o conflito com System.Threading.Tasks.Task.
using Task = TaskManager.Models.Task;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Defines the route as /api/tasks
    public class TasksController : ControllerBase
    {
        // Using a static list to simulate a database for this example.
        private static readonly List<Task> _tasks = new List<Task>
        {
            new Task { Id = 1, Title = "Learn ASP.NET Core", IsCompleted = true },
            new Task { Id = 2, Title = "Build a Web API", IsCompleted = false },
            new Task { Id = 3, Title = "Write unit tests", IsCompleted = false }
        };
        private static int _nextId = 4;

        // GET: api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetTasks()
        {
            return Ok(_tasks);
        }

        // GET: api/tasks/5
        [HttpGet("{id}")]
        public ActionResult<Task> GetTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return NotFound(); // Returns a 404 Not Found response.
            }

            return Ok(task); // Returns a 200 OK response with the task.
        }

        // POST: api/tasks
        [HttpPost]
        public ActionResult<Task> CreateTask(Task newTask)
        {
            if (newTask == null || string.IsNullOrWhiteSpace(newTask.Title))
            {
                return BadRequest("Task title cannot be empty.");
            }

            newTask.Id = _nextId++;
            _tasks.Add(newTask);

            // Returns a 201 Created response with a Location header pointing to the new resource.
            return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, newTask);
        }

        // PUT: api/tasks/5
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Task updatedTask)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask == null)
            {
                return NotFound();
            }

            existingTask.Title = updatedTask.Title;
            existingTask.IsCompleted = updatedTask.IsCompleted;

            return NoContent(); // Standard response for a successful PUT (204 No Content).
        }

        // DELETE: api/tasks/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            _tasks.Remove(task);

            return NoContent(); // Standard response for a successful DELETE (204 No Content).
        }
    }
}
