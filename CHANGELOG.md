# Changelog

Todas as mudanças notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em Keep a Changelog, e este projeto adere ao Versionamento Semântico.

<!--
A Regra do "Major Zero" (Versão 0.y.z)
    De acordo com o Versionamento Semântico, uma versão MAJOR (o primeiro número) igual a zero tem um significado especial:

    A versão 0.y.z é para o desenvolvimento inicial. Qualquer coisa pode mudar a qualquer momento. A API pública não deve ser considerada estável.

Em outras palavras:

    0.1.0 (Desenvolvimento Inicial):
        Ao usar 0.1.0, você está comunicando que o projeto está em sua fase inicial, como um "laboratório". É o primeiro conjunto de funcionalidades (MINOR = 1) adicionado, mas a estrutura geral ainda pode sofrer grandes alterações incompatíveis sem aviso prévio. É um sinal para outros desenvolvedores de que o projeto não está "pronto para produção".
    1.0.0 (Primeira Versão Estável):
        Lançar a versão 1.0.0 é um marco importante.
        Significa que você está declarando que o projeto atingiu um estado estável. A partir desse ponto, você se compromete a não fazer alterações que quebrem a compatibilidade (breaking changes) sem antes incrementar a versão MAJOR (para 2.0.0).

Em resumo:
    0.1.0: "Olá, mundo! Este é o começo do meu laboratório de estudos. A estrutura e os projetos podem mudar drasticamente."
    1.0.0: "Ok, a base do projeto está sólida e estável. A partir de agora, seguirei as regras de compatibilidade à risca."
-->

## [Unreleased]

## [0.1.0] 2025-09-19

### Added

- Adicionado projetos `HelloWorld` (`src/api/Apps/HelloWorld/`) e `TaskManager` (`src/api/Apps/TaskManager/`).
  - **Descrição:** Web APIs criadas com o template `webapi`, mas refatorada para o padrão MVC, introduzindo a estrutura de Controllers do ASP.NET Core.
  - **Tópicos abordados:**
    - **Controllers e Actions:** Organização da lógica de endpoints com o padrão MVC.
      - `Program.cs` foi atualizado para registrar e mapear os controllers.
      - Criação de `Controllers` e `Actions` para definir endpoints.
      - Uso de `Models` para representar os dados.
    - **CRUD:** Implementa um CRUD (Create, Read, Update, Delete) completo.
    - **Verbos HTTP:** Mapeamento de `[HttpGet]`, `[HttpPost]`, `[HttpPut]` e `[HttpDelete]`.
    - **Model Binding:** Conversão de dados da requisição (JSON) para objetos C#.
    - **Respostas HTTP:** Uso de `IActionResult` para retornar status codes semânticos (`Ok`, `NotFound`, `CreatedAtAction`, `NoContent`).
  - **Testes com `.http`**:
    - Adicionado os endpoints para testes rápidos direto no editor de código com a extensão **REST Client** em ambiente de desenvolvimento.
  - **Documentação e Testes com Swagger (OpenAPI):**
    - Habilitado e configurado no ponto de entrada `Program.cs` (documentação interativa e UI para testar cada endpoint diretamente do navegador) em ambiente de desenvolvimento.
- Estrutura inicial do repositório.
- Projetos de console `/src/console/`.
- Documentações `/docs/`: documentação técnica, guias de orientação e anotações de estudo.
- Arquivos de configuração: `.editorconfig`, `.gitignore`.
