using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using Agenda.Infraestructure.Data.Context;

public static partial class Program
{
    public static void Main(string[] args)
    {
        // -------- Builder
        var builder = WebApplication.CreateBuilder(args);

        // --- Add services to the container.
        // Adiciona os serviços necessários para gerar a documentação Swagger.
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Adiciona os serviços para que a API reconheça e use os Controllers.
        builder.Services.AddControllers();

        // Configura o DbContext (AgendaContext) para usar o SQL Server.
        // Lê a string de conexão "DefaultConnection" do arquivo appsettings.Development.json
        builder.Services.AddDbContext<AgendaContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        );

        // -------- App
        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        // Mapeia as rotas definidas nos seus arquivos de Controller.
        app.MapControllers();

        app.Run();
    }
}
