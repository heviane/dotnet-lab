using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

// Simple "Hello World" web application using minimal APIs in ASP.NET Core
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// DTO (Data Transfer Object) para receber login
app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "heviane@gmail.com" && loginDTO.Password == "123456")
    {
        return Results.Ok("Login successful!");
    }
    else
    {
        return Results.Unauthorized();
    }
});

// Configurado launch.json in .vscode para executar em modo DEBUG
app.Run();

public class LoginDTO
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
}
