# Entendendo o Template `dotnet new webapi`

O comando `dotnet new webapi --name Stock.API` é o ponto de partida padrão para a criação de um microserviço ou API REST no ecossistema .NET. Ele utiliza um template da Microsoft para gerar um projeto completo e funcional, com uma estrutura bem definida, permitindo que o desenvolvedor se concentre na lógica de negócio.

## Estrutura de Arquivos Gerada

Ao executar o comando dentro da pasta `src/`, ele criará um novo diretório chamado `Stock.API` com a seguinte estrutura de arquivos e pastas:

```bash
src/
└── Stock.API/
    ├── Controllers/
    │   └── WeatherForecastController.cs  # Controller de exemplo
    ├── Properties/
    │   └── launchSettings.json
    ├── appsettings.Development.json
    ├── appsettings.json
    ├── Program.cs
    ├── Stock.API.csproj
    └── WeatherForecast.cs              # Modelo de exemplo
```

## O que cada arquivo principal faz?

* **`Stock.API.csproj`**: Este é o arquivo de projeto no formato MSBuild. Ele define as configurações, as dependências (pacotes NuGet), a versão do .NET (ex: `net8.0`) e outras propriedades do projeto de API.

* **`Program.cs`**: É o coração da sua aplicação. Com as "Minimal APIs" do .NET 6+, este arquivo se tornou o ponto de entrada único onde você:
  * Configura e inicia o servidor web (Kestrel).
  * Registra serviços para injeção de dependência (como o `StockDbContext` que você adiciona depois).
  * Define o pipeline de requisições HTTP, adicionando middlewares como roteamento, autenticação, CORS e o Swagger.

* **`Controllers/`**: Esta pasta é a localização padrão para os "Controllers", que são as classes responsáveis por agrupar e definir os endpoints da sua API.

* **`WeatherForecastController.cs` e `WeatherForecast.cs`**: Estes são um controller e um modelo de **exemplo** que a Microsoft inclui para que você tenha uma API funcional e testável logo de cara. A prática comum é **deletar esses dois arquivos** e criar seus próprios controllers e modelos, como o `ProductsController.cs` e `Product.cs` do seu guia.

* **`appsettings.json`**: Arquivo de configuração principal no formato JSON. Aqui você colocará configurações que não são sensíveis, como configurações de logging.
  * **`appsettings.Development.json`**: Sobrescreve as configurações do `appsettings.json` apenas quando o ambiente está definido como "Development". É o local ideal para colocar a string de conexão do seu banco de dados local.

* **`Properties/launchSettings.json`**: Define as configurações de como a sua aplicação será iniciada em ambiente de desenvolvimento a partir do Visual Studio ou do comando `dotnet run`. Inclui a URL (ex: `localhost:5001`), se o navegador deve ser aberto automaticamente e variáveis de ambiente. Este arquivo **não é usado em produção**.

Em resumo, o comando `dotnet new webapi` cria um "esqueleto" robusto e alinhado com as melhores práticas, economizando tempo de configuração e fornecendo uma base sólida para o desenvolvimento do seu microserviço.
