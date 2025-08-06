# Guia de Versionamento Semântico (SemVer)

Este documento descreve como o versionamento é aplicado neste projeto de estudos, seguindo as diretrizes do [Versionamento Semântico 2.0.0](https://semver.org/lang/pt-BR/).

O versionamento nos ajuda a entender o escopo das alterações entre as "entregas" ou marcos de estudo, e funciona em conjunto com o [CHANGELOG.md](./CHANGELOG.md).

## O Padrão: MAJOR.MINOR.PATCH

O versionamento semântico usa um formato de três partes: `MAIOR.MENOR.CORREÇÃO`.

- **MAIOR (MAJOR)**: Incrementada quando são feitas alterações incompatíveis (breaking changes). Para este repositório, isso significaria uma reestruturação completa ou uma mudança fundamental no foco dos estudos que invalida a estrutura anterior.

- **MENOR (MINOR)**: Incrementada quando novas funcionalidades são adicionadas de forma compatível com as versões anteriores. No nosso contexto, isso se traduz em:
  - Adicionar um novo projeto de estudo (ex: uma nova API, um app de console).
  - Concluir um novo módulo de aprendizado significativo.
  - Adicionar um novo conjunto de exemplos práticos.

- **CORREÇÃO (PATCH)**: Incrementada para correções de bugs ou pequenas melhorias que são compatíveis com a versão anterior. Por exemplo:
  - Corrigir um erro em um código de exemplo.
  - Melhorar a documentação ou corrigir erros de digitação.
  - Atualizar dependências.

## Como Aplicar Neste Projeto

Nosso fluxo de trabalho de versionamento será o seguinte:

1.  **Versão Inicial**: O projeto começa em `0.1.0`, que marca a configuração inicial do repositório.

2.  **Desenvolvimento Contínuo**: Todas as novas adições (projetos, anotações) e correções são registradas na seção `[Unreleased]` do `CHANGELOG.md`.

3.  **Fechando uma Versão**: Quando um marco de estudo é alcançado (ex: finalização de um projeto de API), nós "lançamos" uma nova versão.
    - Se adicionamos um novo projeto, a versão `0.1.0` se torna `0.2.0`.
    - Se apenas corrigimos um bug em um exemplo, a versão `0.1.0` se torna `0.1.1`.

4.  **Processo de Lançamento**:
    - No `CHANGELOG.md`, renomeie a seção `[Unreleased]` para a nova versão (ex: `[0.2.0] - 2024-05-21`).
    - Crie uma nova seção `[Unreleased]` vazia no topo.
    - Atualize os links de comparação de tags no final do arquivo.
    - Crie uma tag no Git correspondente à nova versão (ex: `git tag -a v0.2.0 -m "Release 0.2.0"`).
    - Envie a tag para o repositório remoto (`git push origin v0.2.0`).

Este processo mantém o histórico do seu aprendizado claro, organizado e fácil de navegar.