# 🏷️ Guia para Versionamento

Este documento descreve como o versionamento é aplicado neste projeto de estudos, seguindo as diretrizes do **[Versionamento Semântico 2.0.0](https://semver.org/lang/pt-BR/)**.

> O versionamento nos ajuda a entender o escopo das alterações entre as "entregas" ou marcos de estudo, e funciona em conjunto com o arquivo [CHANGELOG.md](./CHANGELOG.md).

---

## 🔢 O Padrão: `MAJOR.MINOR.PATCH`

O versionamento semântico usa um formato de três partes: `MAIOR.MENOR.CORREÇÃO`. Cada parte tem um significado específico:

- **💥 MAIOR (MAJOR)**: Incrementada quando são feitas **alterações incompatíveis** (breaking changes). Para este repositório, isso significaria uma reestruturação completa ou uma mudança fundamental no foco dos estudos que invalida a estrutura anterior.

- **✨ MENOR (MINOR)**: Incrementada quando **novas funcionalidades** são adicionadas de forma compatível com as versões anteriores. No nosso contexto, isso se traduz em:
  - Adicionar um novo projeto de estudo (ex: uma nova API, um app de console).
  - Concluir um novo módulo de aprendizado significativo.
  - Adicionar um novo conjunto de exemplos práticos.

- **🐛 CORREÇÃO (PATCH)**: Incrementada para **correções de bugs** ou pequenas melhorias que são compatíveis com a versão anterior. Por exemplo:
  - Corrigir um erro em um código de exemplo.
  - Melhorar a documentação ou corrigir erros de digitação.
  - Atualizar dependências (sem breaking changes).

---

## 🚀 Como Aplicar Neste Projeto

Nosso fluxo de trabalho de versionamento é simples e direto:

1. **Versão Inicial**: O projeto começa em `0.1.0`, que marca a configuração inicial do repositório e a estrutura base.

2. **Desenvolvimento Contínuo**: Todas as novas adições (projetos, anotações) e correções são registradas na seção `[Unreleased]` do `CHANGELOG.md` à medida que são feitas.

3. **Fechando uma Versão**: Quando um marco de estudo é alcançado (ex: finalização de um projeto de API), nós "lançamos" uma nova versão.
    - Se adicionamos um novo projeto, a versão `0.1.0` se torna `0.2.0` (incremento `MINOR`).
    - Se apenas corrigimos um bug em um exemplo, a versão `0.1.0` se torna `0.1.1` (incremento `PATCH`).

4. **Processo de Lançamento (Release)**:
    - No `CHANGELOG.md`, renomeie a seção `[Unreleased]` para a nova versão (ex: `[0.2.0] - 2024-05-21`).
    - Crie uma nova seção `[Unreleased]` vazia no topo do mesmo arquivo.
    - Atualize os links de comparação de tags no final do `CHANGELOG.md`.
    - Crie uma tag no Git correspondente à nova versão:

        ```bash
        git tag -a v0.2.0 -m "Release 0.2.0"
        ```

    - Envie a tag para o repositório remoto:

        ```bash
        git push origin v0.2.0
        ```

Este processo mantém o histórico do seu aprendizado claro, organizado e fácil de navegar ao longo do tempo.
