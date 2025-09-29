# Projeto: TaskManager API

Este é um projeto de **Web API** criado com o template `webapi` do ASP.NET Core, focado no uso de **Controllers** para implementar um CRUD (Create, Read, Update, Delete) completo.

---

## 🎯 Objetivo

O objetivo deste projeto é servir como um exemplo prático de como construir uma API RESTful usando o padrão MVC (Model-View-Controller).

Os principais conceitos abordados são:

- **Controllers e Actions**: Organização de endpoints em classes.
- **Verbos HTTP**: Mapeamento de `[HttpGet]`, `[HttpPost]`, `[HttpPut]` e `[HttpDelete]` para as operações CRUD.
- **Model Binding**: Conversão automática de JSON para objetos C#.
- **Respostas HTTP**: Uso de `Ok()`, `NotFound()`, `CreatedAtAction()`, `NoContent()` e `BadRequest()` para retornar os status codes corretos.

---

## ✅ Pré-requisitos

Antes de executar, certifique-se de que você tem o **SDK do .NET** instalado.

---

## 🚀 Como Executar

Para executar o projeto, navegue até a pasta e use o comando `watch` para que a API reinicie automaticamente após cada alteração no código.

```bash
cd src/api/Apps/TaskManager
dotnet watch run
```

Após a execução, a API estará disponível e você pode interagir com ela através da documentação Swagger:

- **Documentação Swagger**: `http://localhost:<porta>/swagger`

A página do Swagger permitirá que você teste todos os endpoints do `TasksController`.

---

## 📂 Estrutura do Projeto

- `Controllers/TasksController.cs`: O coração da API. Contém toda a lógica para gerenciar tarefas (criar, ler, atualizar e deletar).
- `TaskManager.csproj`: O arquivo de projeto. Define as configurações da aplicação e suas dependências, como o `Swashbuckle.AspNetCore` para a documentação Swagger.
- `Models/Task.cs`: O modelo de dados que representa uma tarefa.
- `Program.cs`: Arquivo de inicialização que configura os serviços e o pipeline da aplicação, incluindo o mapeamento dos controllers.
