# Trilha de Aprendizagem .NET

Este documento serve como um guia estruturado para seus estudos no ecossistema .NET. A trilha foi desenhada para progredir de forma lógica, dos conceitos fundamentais aos tópicos mais avançados, sempre com foco na prática.

---

## Módulo 1: Fundamentos do C# e do Ecossistema .NET

Tudo começa aqui. O objetivo é construir uma base sólida na linguagem C# e entender a plataforma .NET e suas ferramentas essenciais.

### 🎯 Objetivos

- Aprender a programar em C#, dominar a sintaxe e os principais recursos.
- Sentir-se confortável usando a CLI (Interface de Linha de Comando) do `dotnet`.

### 📚 Tópicos de Estudo

- **C# (Sintaxe e Fundamentos):** Variáveis, tipos de dados, operadores, estruturas de controle (if, else, switch), laços (for, while, foreach), métodos e namespaces.
- **C# (Orientação a Objetos):**
  - Classes e Objetos
  - Propriedades, Métodos e Construtores
  - Pilares da OO: Encapsulamento, Herança e Polimorfismo
  - Interfaces e Classes Abstratas
- **.NET CLI:** Comandos essenciais como `dotnet new`, `dotnet run`, `dotnet build` e `dotnet sln`.

### 💻 Prática

- **Projeto:** Crie várias **Aplicações de Console** para resolver problemas simples.
- **Exemplos:** Uma calculadora, um pequeno jogo de adivinhação, um programa que manipula textos.
- **Local:** `src/console/`

---

## Módulo 2: Construindo APIs com ASP.NET Core

Com a base sólida, é hora de construir serviços web. As Web APIs são a espinha dorsal da maioria das aplicações modernas.

### 🎯 Objetivos

- Entender os conceitos de HTTP e da arquitetura REST.
- Criar endpoints que expõem dados e funcionalidades.

### 📚 Tópicos de Estudo

- **Conceitos:** HTTP (Verbos, Status Codes), REST, JSON.
- **ASP.NET Core:** Estrutura de um projeto Web API, Roteamento, Controllers, Injeção de Dependência (DI) e o pipeline de requisições (`Program.cs`).

### 💻 Prática

- **Projeto:** Crie uma **Web API** para um sistema simples.
- **Exemplos:** Uma API de lista de tarefas (To-Do List) ou um catálogo de filmes/livros.
- **Local:** `src/api/`

---

## Módulo 3: Organização e Qualidade de Código

Escrever código que funciona é o primeiro passo. Escrever código limpo, organizado e testável é o que diferencia um profissional.

### 🎯 Objetivos

- Aprender a separar responsabilidades e criar código reutilizável.
- Entender a importância dos testes automatizados.

### 📚 Tópicos de Estudo

- **Arquitetura:** Princípios SOLID, separação de camadas (ex: Controller, Service, Repository).
- **Testes:** Conceitos de Testes de Unidade. Frameworks como xUnit.

### 💻 Prática

1. **Refatoração:** Mova a lógica de negócio da sua API para um projeto do tipo **Class Library**.
    - **Local:** `src/library/`
2. **Testes:** Crie um **Projeto de Testes** para validar a lógica da sua Class Library, garantindo que ela funcione corretamente de forma isolada.
    - **Local:** `src/tests/`

---

## Módulo 4: Acesso a Dados com Entity Framework Core

Aplicações reais precisam persistir dados. Aqui você aprenderá a conectar sua API a um banco de dados de forma eficiente.

### 🎯 Objetivos

- Aprender a modelar e consultar dados de um banco de dados usando C#.

### 📚 Tópicos de Estudo

- **ORM:** O que é um Object-Relational Mapper.
- **EF Core:** `DbContext`, `DbSet`, Migrations, e consultas com LINQ (Language-Integrated Query).

### 💻 Prática

- **Projeto:** Integre o Entity Framework Core na sua Web API para salvar e recuperar os dados de um banco de dados (comece com o SQLite, que é baseado em arquivo e muito simples de configurar).

---

## Módulo 5: Tópicos Avançados e Próximos Passos

Com uma aplicação funcional, é hora de explorar o que mais o ecossistema .NET tem a oferecer.

### 📚 Tópicos para Explorar

- **Programação Assíncrona:** `async` e `await` para aplicações responsivas.
- **Autenticação e Autorização:** Protegendo sua API (ex: com JWT).
- **Containers:** Empacotando sua aplicação com Docker.
- **Outros Tipos de Projeto:** Explore **ASP.NET Core MVC** ou **Blazor** para criar aplicações web com interface de usuário.

---

## Recursos

- O [Microsoft Learn](https://learn.microsoft.com/dotnet) é a sua principal fonte de estudo. A plataforma oficial da Microsoft oferece trilhas de aprendizagem, tutoriais e documentação completa para todo o ecossistema .NET.
