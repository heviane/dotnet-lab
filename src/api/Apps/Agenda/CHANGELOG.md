# Changelog

Todas as mudanças notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
e este projeto adere ao [Versionamento Semântico](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- **User Interface**: Criar frontend com MVC.

### Changed

### Fixed

## [1.0.0] - 2025-09-30

Versão inicial da API de Agenda, com funcionalidades completas de gerenciamento de contatos.

### Added

- **Estrutura do Projeto**: Configuração inicial da API com .NET 9.
- **Acesso a Dados**: Integração com Entity Framework Core e SQL Server.
- **Migrations**: Primeira migration para criar a tabela de `Contacts`.
- **Endpoints CRUD**:
  - `POST /api/contact`: Cria um novo contato.
  - `GET /api/contact`: Lista todos os contatos.
  - `GET /api/contact/{id}`: Busca um contato por ID.
  - `PUT /api/contact/{id}`: Atualiza um contato de forma completa.
  - `DELETE /api/contact/{id}`: Deleta um contato.
- **Endpoints Adicionais**:
  - `GET /api/contact/{name}`: Busca contatos por nome.
  - `PATCH /api/contact/{id}`: Atualiza parcialmente o telefone e email de um contato.
- **Documentação**:
  - Adicionado `README.md` com instruções de setup e guia de endpoints.
  - Configuração do Swagger/OpenAPI para documentação interativa.
- **Testes**: Adicionado arquivo `Agenda.http` para testes manuais dos endpoints.

### Fixed

- **Roteamento**: Corrigida a ambiguidade de rotas entre `GetById` e `GetByName` com a adição da restrição `:int`.
