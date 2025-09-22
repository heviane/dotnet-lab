// See https://aka.ms/new-console-template for more information

/* ------------- Minimal API - Hello World -------------

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

// Simple "Hello World" web application using minimal APIs in ASP.NET Core
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // http://localhost:5040/
app.Run();
------------- */

// ------------- API com Controllers e Swagger -------------
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Adiciona os serviços necessários para gerar a documentação Swagger.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona os serviços para que a API reconheça e use os Controllers.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Habilita o Swagger e a UI do Swagger apenas em ambiente de desenvolvimento.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia as rotas definidas nos seus arquivos de Controller.
app.MapControllers();

app.Run();
