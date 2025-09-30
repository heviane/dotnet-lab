# Entity Framework

**Entity Framework (EF) Core** é o ORM (Mapeador Objeto-Relacional) moderno, de código aberto e multiplataforma do ecossistema .NET. Ele permite que desenvolvedores trabalhem com um banco de dados usando objetos C# em vez de escrever código SQL diretamente.

O objetivo principal do EF Core é aumentar a produtividade do desenvolvedor, automatizando a maior parte das tarefas de acesso a dados.

**Camadas**: User Interface > Business Layer (Business Entities/Domain Classes) > *Data Layer (Entity Framework)* > Database Layer (Microsoft SQL Server)

Abstrae a criação e execução de queries.

---

## 💡 Onde o Entity Framework pode ser usado?

O EF Core é uma biblioteca de acesso a dados e não está atrelado a um tipo específico de aplicação. Ele pode ser utilizado em praticamente **qualquer tipo de projeto .NET** que precise de persistência de dados.

Isso inclui:

- **Web APIs (ASP.NET Core)**: O cenário mais comum, onde a API serve como uma ponte entre os clientes (navegadores, apps mobile) e o banco de dados.
- **Aplicações Web (MVC, Razor Pages, Blazor)**: Para criar sites e sistemas web dinâmicos que consultam e manipulam dados.
- **Aplicações de Console e Worker Services**: Ideal para tarefas em background, scripts de migração de dados ou serviços de processamento contínuo.
- **Aplicações Desktop (WPF, WinForms, .NET MAUI)**: Para conectar aplicações de desktop a um banco de dados central ou gerenciar um banco de dados local (ex: SQLite).
- **Aplicações Mobile (.NET MAUI)**: Para armazenar dados localmente no dispositivo (iOS/Android) ou sincronizar com um servidor remoto.
- **Serviços de Nuvem (Azure Functions)**: Em arquiteturas serverless, para executar operações de banco de dados de forma rápida e eficiente.

Em resumo, se o seu código C# precisa conversar com um banco de dados, o EF Core é a ferramenta padrão e recomendada para fazer essa comunicação de forma produtiva e segura.

## CRUD

São as operações mais básicas e comuns do banco de dados:

- Create
- Read
- Update
- Delete

Na prática, uma tabela e uma classe são associadas.
Um objeto será um registro do banco de dados.
O EF gera queries dinamicamente, cria tabelas de acordo com a operação desejada.

## Instalações

### Instalações Globais (Uma única vez na máquina)

```bash
dotnet tool install --global dotnet-ef
```

### Instalações por Projeto (A cada novo projeto iniciado)

Todos os pacotes devem ser instalados por projeto!

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

Verifique o arquivo `.csproj` para conferir as dependências.

## Exemplo Prático de Uso

### 1. Criação do Banco de Dados e da Tabela de Contatos

1. Adicionar os pacotes necessários ao projeto.
2. Criar o diretório `Entities` e as classes que representam tabelas no banco de dados (ex: Contact)
3. Criar o contexto (Classe que centraliza todas as informações do banco de dados):
   1. Criar o diretório `Context`.
   2. Criar uma classe chamada `AgendaContext.cs` (Pode ser qualquer nome) que herde de `DbContext`.
4. Criar as configurações de conexão com o banco de dados no arquivo de configuração do projeto.
   - `appsettings.json`: Para ambiente de produção (Dados reais para a implantação do sistema).
   - `appsettings.Development.json`: Para ambiente de desenvolvimento e testes (Exemplo: Configurar para não enviarmos e-mails).
5. Configurar a string de conexão configurada em `appsettings.Development.json` no contexto `AgendaContext.cs`.
   - Criar um método construtor especial para receber a string de conexão do banco de dados.
6. Configurar a classe main `Program.cs` para adicionar o contexto:

```bash
// Configura o DbContext (AgendaContext) para usar o SQL Server.
// Lê a string de conexão "DefaultConnection" do arquivo appsettings.Development.json
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
```

7. **`Migrations`**: Criar as Migrations.
O EF gera os comandos sql de forma dinâmica, mas os comandos de criação de tabelas devem ser feitos manualmente.
Tudo que estiver no contexto `AgendaContext.cs` como `DbSet` deve virar uma tabela no banco de dados.
Ou seja, todas as criações de tabelas temos que pedir ao EF para criar de forma antecipada.
E esta forma antecipada é chamada de **Migrations**. Nada mais é que o mapeamento que o EF faz das classes para poder transforma-las em tabelas.
Nada mais é do que um código para espelhar as classes no banco de dados em forma de tabelas.

    ```bash
    # O EF cria automaticamente o diretório 'Migrations' e os arquivos necessários.

    ## Exemplo simples
    dotnet ef migrations add ContactEntityCreate

    ## Em uma solução com múltiplos projetos (ex: `WebApi` e `Infrastructure`), você pode especificar o diretório de saída e os projetos de inicialização e de dados.
    dotnet ef migrations add ContactEntityCreate --project src/api/Apps/Agenda -o Infrastructure/Data/Migrations
    ### - **`--project src/Infrastructure`**: Especifica que o `DbContext` está no projeto `Infrastructure`.
    ### - **`-o Data/Migrations`**: Cria as migrações dentro da pasta `Data/Migrations` no projeto `Infrastructure`.
    ```

Serão gerados os seguintes:

- Snapshot:
- designer:
- a própria classe, contando dois métodos:
  - up: Para aplicar as mudanças no banco de dados (Criar a tabela).
  - down: Para fazer rollback.

8. **`Migrations`**: Aplicar as Migrations.

```bash
dotnet ef database update # funcionou, mesmo a pasta Migrations não estando na raiz do projeto
```

### 2. Criação do Controller e do endpoint de Create (CRUD)

1. Criar o arquivo `ContactController.cs` em `/WebApi/Controllers`.
Basta configurar aqui o contexto e os endpoints, que automaticamente eles aparecerão na documentação swagger ao executar a api com `dotnet run`.

### 3. Testando os Endpoints

Depois de criar o `ContactController` com os endpoints de CRUD, a maneira mais rápida de testá-los é usando a documentação **Swagger** ou um arquivo **`.http`**.

#### Usando o Arquivo `.http`

Um arquivo `Agenda.http` foi criado dentro do projeto da API. Ele contém exemplos de requisições para todas as operações:

- **`POST /api/contact`**: Para criar um novo contato.
- **`GET /api/contact`**: Para listar todos os contatos.
- **`GET /api/contact/{id}`**: Para buscar um contato específico.
- **`PUT /api/contact/{id}`**: Para atualizar um contato.
- **`DELETE /api/contact/{id}`**: Para deletar um contato.

Para usar, basta iniciar a API (`dotnet watch run`), ajustar a porta no arquivo `Agenda.http` e clicar em "Send Request" para cada requisição que deseja testar.
