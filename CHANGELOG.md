# Changelog

Todas as mudanças notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em Keep a Changelog, e este projeto adere ao Versionamento Semântico.

## [Unreleased]

## [0.1.0] - 2024-09-19

### Added

- **Estrutura Inicial do Repositório:**
  - Configuração de arquivos base como `.editorconfig` e `.gitignore`.
  - Definição da estrutura de pastas `src/` e `docs/`.
  - Adição de guias iniciais, documentação e projetos de console.
- **Projeto `HelloWorld` API (`src/api/Apps/HelloWorld/`):**
  - Introduz a estrutura de uma Web API com o padrão MVC (Controllers).
  - Aborda a criação de `Controllers`, `Actions` e `Models`.
  - Inclui exemplos de testes com arquivos `.http` e documentação com Swagger.
- **Projeto `TaskManager` API (`src/api/Apps/TaskManager/`):**
  - Implementa um CRUD (Create, Read, Update, Delete) completo para gerenciamento de tarefas.
  - Demonstra o uso prático de verbos HTTP (`GET`, `POST`, `PUT`, `DELETE`).
  - Aplica conceitos como `Model Binding` e o uso de `IActionResult` para respostas HTTP semânticas.
- **Documentação de API (`docs/courses/dotnet/api/`):**
  - Adicionados guias sobre como testar endpoints com Swagger e arquivos `.http`.
