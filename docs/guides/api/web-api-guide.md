# Guia de Projetos Web API com ASP.NET Core

Este guia serve como uma introdução à criação de projetos **Web API** com ASP.NET Core, o ponto de partida para a Fase 2 do nosso roadmap.

Uma Web API é um serviço que expõe funcionalidades e dados através do protocolo HTTP, geralmente retornando dados em formato JSON. Elas são a base para a comunicação entre sistemas modernos, como um site (frontend) consumindo dados de um servidor (backend).

## 📂 Estrutura de um Projeto Web API

Ao criar um novo projeto de Web API (`dotnet new webapi`), você encontrará alguns arquivos e conceitos essenciais:

### 1. `Program.cs`

Este é o coração da sua aplicação. Em .NET 6 e versões mais recentes, este arquivo foi simplificado e é responsável por duas tarefas principais:

- **Configuração de Serviços (Injeção de Dependência)**: Aqui você "registra" os serviços que sua aplicação usará. Por exemplo, o serviço de banco de dados (EF Core), serviços de autenticação, ou serviços customizados que você mesmo criou.
- **Configuração do Pipeline de Requisição HTTP**: Aqui você define como a sua API responderá a uma requisição. Cada `app.Use...` adiciona um "middleware" ao pipeline, que processa a requisição em etapas (ex: roteamento, autenticação, autorização).

### 2. Controllers

Controllers são classes C# que agrupam um conjunto de *actions* (métodos) relacionados. O nome da classe geralmente termina com o sufixo `Controller`.

- **Responsabilidade**: Receber requisições HTTP, processá-las (geralmente usando outros serviços) e retornar uma resposta HTTP (como um `Ok()`, `NotFound()` ou `BadRequest()`).
- **Roteamento**: Atributos como `[ApiController]` e `[Route("api/[controller]")]` definem como a URL de uma requisição é mapeada para um controller específico.

### 3. Actions

Actions são os métodos públicos dentro de um controller. Eles são decorados com atributos HTTP que especificam qual verbo HTTP eles respondem:

- `[HttpGet]`: Para buscar dados.
- `[HttpPost]`: Para criar um novo recurso.
- `[HttpPut]`: Para atualizar um recurso existente.
- `[HttpDelete]`: Para remover um recurso.

### 4. Model Binding

O ASP.NET Core automaticamente converte os dados da requisição (como um corpo JSON em um `POST`) em objetos C#. Isso é chamado de *Model Binding*. Você simplesmente declara o objeto como um parâmetro da sua action, e o framework cuida do resto.

> Este guia é apenas o começo. À medida que avançamos no roadmap, exploraremos conceitos como Injeção de Dependência, acesso a dados com EF Core e segurança de forma muito mais aprofundada.
