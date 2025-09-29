# Entendendo o Arquivo de Solução (.sln)

O arquivo com a extensão `.sln` é um **Solution File** (Arquivo de Solução) do .NET.

> Pense nele como um "contêiner" 📦 ou um "índice" que organiza um ou mais projetos relacionados (`.csproj`, `.vbproj`, etc.) em uma única unidade de trabalho coesa.

Ele é a peça central para o desenvolvimento em larga escala e é utilizado principalmente por duas ferramentas:

1. **Visual Studio**: Para carregar todos os projetos, suas dependências e configurações em um único ambiente de desenvolvimento integrado (IDE).
2. **CLI do .NET**: Para executar comandos como `dotnet build`, `dotnet test` ou `dotnet publish` em todos os projetos da solução de uma só vez.

---

## 🎯 Para que serve?

A principal finalidade de um arquivo de solução é **gerenciar a complexidade** de aplicações com múltiplos projetos. Em vez de abrir cada projeto individualmente, você abre o arquivo `.sln`, e ele cuida de:

- **Agrupar Projetos**: Manter juntos uma API, uma biblioteca de classes e um projeto de testes, por exemplo.
- **Definir Dependências de Build**: Estabelecer a ordem em que os projetos são compilados (ex: "Projeto A" deve ser compilado antes do "Projeto B").
- **Gerenciar Configurações**: Definir quais projetos devem ser compilados para diferentes configurações, como `Debug` ou `Release`.
- **Organização Visual**: Criar "pastas de solução" (como a pasta `src` neste projeto) para organizar os projetos visualmente no Visual Studio, sem alterar a estrutura de arquivos no disco.

> À medida que você adicionar novos projetos (uma API, uma biblioteca, testes), eles também serão adicionados a este arquivo, permitindo que você gerencie todos juntos a partir da solução.

## Principais comandos via terminal

1. Criar uma solution

```bash
dotnet new sln
```

2. Adicionar um projeto a solution

```bash
dotnet sln add src\HelloWorld\HelloWorld.csproj
```

3. Listar projetos dentro da solution

```bash
dotnet sln list
```

---

## Extensões VSCode

- [vscode-solution-explorer](https://github.com/fernandoescolar/vscode-solution-explorer)

## Notes

- evita suplicação de código, por exemplo, qdo tem um projeto em comum, que é usado por outros projetos dentro da solução.
  - Quando um projeto depende de outro, ou seja, um projeto usa outro projeto, e assim compartilham código.
