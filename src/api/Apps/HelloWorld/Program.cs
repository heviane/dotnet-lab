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
