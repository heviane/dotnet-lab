using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona os serviços ao contêiner de injeção de dependência.

// Adiciona os serviços para controllers. Essencial para que a API reconheça as classes Controller.
builder.Services.AddControllers();

// Adiciona os serviços do Swagger/OpenAPI para geração de documentação.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 2. Configura o pipeline de requisições HTTP.

// Habilita a interface do Swagger apenas em ambiente de desenvolvimento.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia as rotas definidas nos controllers.
app.MapControllers();

app.Run();
