# Agenda API

Uma API RESTful simples e robusta para gerenciamento de contatos, construída com ASP.NET Core e Entity Framework Core. Este projeto serve como um exemplo prático da implementação de funcionalidades CRUD (Create, Read, Update, Delete) completas, seguindo práticas modernas de desenvolvimento .NET.

## ✨ Features

- **Operações CRUD completas** para contatos.
- **Busca de contatos** por ID ou por nome (parcial).
- **Atualizações parciais** de recursos utilizando `HTTP PATCH`.
- **Gerenciamento de banco de dados** com Entity Framework Core Migrations.
- **Documentação de API interativa** e automatizada com Swagger (OpenAPI).

## 🛠️ Tecnologias Utilizadas

- **.NET 9** - Framework de desenvolvimento.
- **ASP.NET Core** - Para a construção da API.
- **Entity Framework Core 9** - ORM para acesso a dados.
- **SQL Server** - Banco de dados relacional.
- **Swagger (Swashbuckle)** - Para documentação da API.

## 📋 Pré-requisitos

Antes de começar, certifique-se de ter instalado em sua máquina:

- .NET 9 SDK
- dotnet-ef global tool (`dotnet tool install --global dotnet-ef`)
- Uma instância do SQL Server (LocalDB, Express, Docker, etc.).

## 🚀 Getting Started

Siga os passos abaixo para configurar e executar o projeto localmente.

### 1. Clone o Repositório

```bash
git clone <URL_DO_SEU_REPOSITORIO>
cd dotnet-lab/src/api/Apps/Agenda
```

### 2. Configure a Conexão com o Banco de Dados

Abra o arquivo `appsettings.Development.json` e atualize a string de conexão `DefaultConnection` para apontar para a sua instância do SQL Server.

**Exemplo para SQL Server LocalDB:**

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgendaDB;Trusted_Connection=True;"
  }
}
```

### 3. Aplique as Migrations

Execute o comando abaixo no terminal, na raiz do projeto `Agenda`, para criar o banco de dados e aplicar as tabelas.

```bash
dotnet ef database update
```

### 4. Execute a Aplicação

```bash
dotnet run
```

A API estará disponível em `http://localhost:5110` (ou na porta configurada no seu `launchSettings.json`).

## 🧪 Como Testar

Você pode testar os endpoints da API de duas maneiras:

1. **Swagger UI**: Navegue para `http://localhost:5110/swagger` no seu navegador para acessar a documentação interativa.
2. **Arquivo `.http`**: Se você usa o Visual Studio Code com a extensão REST Client, abra o arquivo `Agenda.http` e clique em "Send Request" para testar cada endpoint diretamente do editor.

## Endpoints da API

| Verbo  | Rota                  | Descrição                               |
| :----- | :-------------------- | :-------------------------------------- |
| `POST` | `/api/contact`        | Cria um novo contato.                   |
| `GET`  | `/api/contact`        | Retorna uma lista de todos os contatos. |
| `GET`  | `/api/contact/{id}`   | Busca um contato pelo seu ID.           |
| `GET`  | `/api/contact/{name}` | Busca contatos cujo nome contenha o texto. |
| `PUT`  | `/api/contact/{id}`   | Atualiza todas as informações de um contato. |
| `PATCH`| `/api/contact/{id}`   | Atualiza parcialmente um contato (phone e email). |
| `DELETE`| `/api/contact/{id}`  | Deleta um contato.                      |

---

*Este projeto faz parte do repositório `dotnet-lab`, focado em estudos e exemplos práticos com a plataforma .NET.*
