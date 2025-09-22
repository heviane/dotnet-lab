using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace HelloWorld.Controllers
{
    /// <summary>
    /// Controller responsável por operações relacionadas a saudações.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")] // Defines the route as /api/user
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Retorna uma saudação simples "Hello, World!".
        /// </summary>
        /// <returns>Uma string com a saudação.</returns>
        /// <response code="200">Retorna a mensagem "Hello, World!".</response>
        [HttpGet("greet")]
        public ActionResult<string> GetHello()
        {
            return Ok("Hello, World!"); // return only string // Output: "Hello, World!"
        }

        /// <summary>
        /// Retorna uma saudação personalizada para o nome fornecido.
        /// </summary>
        /// <param name="name">O nome a ser incluído na saudação.</param>
        /// <returns>Um objeto JSON com a mensagem de saudação personalizada.</returns>
        /// <response code="200">Retorna a saudação personalizada.</response>
        /// <response code="400">Se o nome fornecido for nulo, vazio ou contiver apenas espaços em branco.</response>
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
