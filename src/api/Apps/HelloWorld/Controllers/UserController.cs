using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace HelloWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Defines the route as /api/user
    public class UserController : ControllerBase
    {
        // Método GET que retorna uma saudação simples, sem parâmetros
        [HttpGet("greet")]
        public ActionResult<string> GetHello()
        {
            return Ok("Hello, World!"); // return only string // Output: "Hello, World!"
        }

        // Método GET que retorna uma saudação personalizada, com um parâmetro de nome
        [HttpGet("greet/{name}")]
        public ActionResult<string> GreetByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name cannot be empty.");
            }
            return Ok(new { Message = $"Hello, {name}!" }); // return JSON object // Output: { "Message": "Hello, {name}!" }
        }
    }
}
