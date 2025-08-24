# Roadmap especialista .NET

Roadmap lógico e progressivo para você se tornar um especialista em .NET, dividido em **fases de aprendizado**, com foco em tecnologias, boas práticas, arquitetura e projetos práticos.

---

## 🟢 Fase 1: Fundamentos do .NET e C# com Console Applications

Tudo começa aqui. O objetivo é construir uma base sólida na linguagem C# e entender a plataforma .NET e suas ferramentas essenciais.

### 🎯 **Objetivos**

- Aprender a programar em C#, dominar a sintaxe e os principais recursos.
- Sentir-se confortável usando a CLI (Interface de Linha de Comando) do `dotnet`.

### 📚 Tópicos de Estudo

- **.NET**
  - Diferença entre .NET Framework, .NET Core e .NET 5/6/7+
  - .NET CLI (`dotnet new`, `dotnet build`, `dotnet run` e `dotnet sln`)
  - Gerenciamento de pacotes com NuGet
- **C# Fundamentos**: É a principal linguagem.
- **Programação Orientada a Objetos**: C# é baseado neste paradigma.
- **SQL e Bancos de Dados Relacionais**: É crucial entender SQL antes de usar uma ferramenta (ORM) que abstrai o acesso a dados.
  - Fundamentos de SQL: `SELECT`, `INSERT`, `UPDATE`, `DELETE`, `JOIN`.
  - Modelagem de dados: Entender como criar tabelas, chaves primárias e estrangeiras.
- **Ferramentas**
  - Visual Studio Code / Visual Studio
  - Git + GitHub
  - Debugging
  - Profiling básico

### 💻 Prática

- **Projeto:** Crie várias **Aplicações de Console** para resolver problemas simples.
- **Exemplos:** Uma calculadora, um pequeno jogo de adivinhação, um programa que manipula textos.

---

## 🟡 Fase 2: Desenvolvimento Web API com ASP.NET Core

Com a base sólida, é hora de construir serviços web. As **Web APIs** são a espinha dorsal da maioria das aplicações modernas.

### 🎯 Objetivos

- Entender os conceitos de HTTP (Verbos, Status Codes), arquitetura REST e JSON.
- Criar endpoints que expõem dados e funcionalidades (serviços HTTP sem interface gráfica). Elas retornam dados brutos (geralmente em formato JSON) para serem consumidos por outras aplicações, como um site feito em JavaScript (React, Angular), um aplicativo mobile ou outro serviço de backend.

### 📚 Tópicos de Estudo

🔹 **ASP.NET Core Fundamentals**

- Estrutura de um projeto Web API, Roteamento, Controllers, Injeção de Dependência (DI) e o pipeline de requisições (`Program.cs`).
- Middleware e pipeline de requisição
- Logging Estruturado com Serilog

🔹 **APIs RESTful**

- Criação de endpoints (CRUD com dados em memória)
- Versionamento de API
- Autenticação e Autorização com JWT
- Boas práticas de segurança: Validação de entrada (Input Validation), gerenciamento de segredos (Secret Management), princípios do OWASP.
- Documentação com Swagger/OpenAPI

### 💻 Prática

- **Projeto:** Crie uma **Web API** para um sistema simples, utilizando dados em memória inicialmente.
- **Exemplos:** Uma API de lista de tarefas (To-Do List) ou um catálogo de filmes/livros.

---

## 🟠 Fase 3: Arquitetura e Boas Práticas - Organização e Qualidade de Código

Escrever código que funciona é o primeiro passo. Escrever código limpo, organizado e testável é o que diferencia um profissional.

### 🎯 Objetivos

- Aprender a separar responsabilidades e criar código reutilizável.
- Entender a importância dos testes automatizados.

### 📚 Tópicos de Estudo

🔹 **Design Patterns**

- Repository, Unit of Work
- Dependency Injection
- Strategy, Factory, Singleton

🔹 **Arquitetura Limpa (Clean Architecture)**

- Separação de responsabilidades
- Separação de camadas (ex: Controller, Service, Repository).
- Camadas: Domain, Application, Infrastructure, Presentation
- SOLID principles

🔹 **Testes**

- xUnit / NUnit
- Moq / FakeItEasy
- Testes de unidade, integração e carga

### 💻 Prática

1. **Refatoração:** Mova a lógica de negócio da sua API para um projeto do tipo **Class Library**.
2. **Testes:** Crie um **Projeto de Testes** para validar a lógica da sua Class Library, garantindo que ela funcione corretamente de forma isolada.

---

## 🟢 Fase 4: Acesso a Dados com Entity Framework Core

Aplicações reais precisam persistir dados. Aqui você aprenderá a conectar sua API a um banco de dados de forma eficiente.

### 🎯 Objetivos

- Aprender a modelar e consultar dados de um banco de dados usando C#.

### 📚 Tópicos de Estudo

- **ORM:** O que é um Object-Relational Mapper.
- **EF Core:** `DbContext`, `DbSet`, Migrations, e consultas com LINQ (Language-Integrated Query).

### 💻 Prática

- **Projeto:** Integre o Entity Framework Core na sua Web API para salvar e recuperar os dados de um banco de dados (comece com o SQLite, que é baseado em arquivo e muito simples de configurar).

---

## 🔵 Fase 5: Tópicos Avançados de Backend

Com uma base sólida em APIs e persistência, é hora de explorar arquiteturas e ferramentas que elevam a qualidade e escalabilidade dos seus serviços.

### 🎯 Objetivos

- Aprender a construir sistemas distribuídos com microserviços.
- Dominar ferramentas que melhoram a produtividade e a observabilidade.

### 📚 Tópicos de Estudo

🔹 **Arquitetura de Microserviços**

- Conceitos e desafios de sistemas distribuídos
- Comunicação via REST ou gRPC
- Mensageria com RabbitMQ ou Azure Service Bus

🔹 **Ferramentas Essenciais (Advanced Tooling)**

- **Dapper**: Alternativa leve ao EF Core para cenários de alta performance.
- **AutoMapper**: Mapeamento de objetos para simplificar a transferência de dados entre camadas.
- **MediatR**: Implementação do padrão Mediator para desacoplar a lógica de negócio (CQRS).
- **Health Checks e Metrics**: Expor a saúde da aplicação para sistemas de monitoramento.

### 💻 Prática

- **Projeto:** Evolua a API anterior para um sistema com dois microserviços (ex: um para "Produtos" e outro para "Pedidos") que se comunicam entre si. Integre Serilog para logging e Health Checks.

---

## 🟣 Fase 6: Desenvolvimento de UI com .NET (Fullstack)

Após dominar o backend, o próximo passo é construir interfaces de usuário ricas e interativas, tornando-se um desenvolvedor fullstack no ecossistema .NET.

### 🎯 Objetivos

- Aprender a criar aplicações web com interface renderizada no servidor ou no cliente (SPA).

### 📚 Tópicos para Explorar

- **ASP.NET Core MVC (Model-View-Controller):** Um padrão clássico para separar a aplicação em três partes: Model (dados), View (a interface) e Controller (o cérebro). Ideal para aplicações grandes e complexas.
- **Razor Pages:** Uma abordagem mais moderna e simplificada, focada em páginas. Cada página tem seu próprio código, tornando-o mais direto para cenários baseados em formulários e CRUD. É a escolha recomendada pela Microsoft para novas aplicações web com UI.
- **Blazor (Server e WebAssembly):** A resposta do .NET a frameworks como React e Angular. Permite criar aplicações web interativas (SPAs) usando C# em vez de JavaScript.

### 💻 Prática

- **Projeto:** Crie um painel administrativo (dashboard) para consumir a Web API que você construiu. Escolha entre Blazor (recomendado para uma experiência moderna) ou Razor Pages.

---

## 🔵 Fase 7: DevOps e Cloud

Escrever o código é apenas metade do trabalho. Um especialista precisa saber como empacotar, distribuir, automatizar e monitorar suas aplicações na nuvem.

### 🎯 Objetivos

- Aprender a conteinerizar aplicações com Docker.
- Entender o fluxo de integração e entrega contínua (CI/CD).
- Publicar e gerenciar aplicações na nuvem (Azure).

### 📚 Tópicos de Estudo

🔹 **Containers**

- Empacotando sua aplicação com Docker (Dockerfile).
- Orquestração básica com Docker Compose.
- Introdução ao Kubernetes (K8s).

🔹 **Cloud com Azure**

- **Serviços de Hospedagem:** Azure App Services, Azure Functions (Serverless).
- **Serviços de Dados:** Azure SQL, Blob Storage, Key Vault.

🔹 **Automação (DevOps)**

- **PowerShell**: Linguagem de script para automação de tarefas, gerenciamento de infraestrutura e pipelines de CI/CD, especialmente no ecossistema Microsoft/Azure.
- CI/CD com GitHub Actions ou Azure DevOps.
- Criar um pipeline que compila, testa e publica sua aplicação automaticamente.

### 💻 Prática

- **Projeto:** Crie um Dockerfile para sua Web API. Crie um pipeline no GitHub Actions que, a cada push na branch `main`, executa os testes e faz o deploy da API para o Azure App Services.

---

## 🧭 Fase 8: Especializações (Mobile & Desktop)

Para aqueles que desejam ir além da web, o .NET oferece uma plataforma unificada para criar aplicações nativas para Windows, macOS, iOS e Android.

### 🎯 Objetivos

- Construir aplicações que rodam em múltiplos sistemas operacionais a partir de uma única base de código.

### 📚 Tópicos de Estudo

🔹 **.NET MAUI (Multi-platform App UI)**

- Estrutura de um projeto MAUI.
- Layouts, páginas e navegação.
- Data binding e MVVM (Model-View-ViewModel).
- Integração com APIs nativas de cada plataforma.

### 💻 Prática

- **Projeto:** Crie um aplicativo mobile (iOS/Android) simples que consome a sua Web API para exibir uma lista de dados.

---

## Recursos

- [Microsoft Learn](https://learn.microsoft.com/dotnet) - Plataforma oficial da Microsoft para aprendizagem.
- [Curso e certificação: Foundational C# with Microsoft](https://www.freecodecamp.org/portuguese/learn/foundational-c-sharp-with-microsoft/)
- [Playgrounds Online Try .NET](https://dotnet.microsoft.com/en-us/platform/try-dotnet)
- [Playgrounds Online .NET Fiddle](https://dotnetfiddle.net)
- [Playgrounds Online replit](https://replit.com/languages/csharp)
