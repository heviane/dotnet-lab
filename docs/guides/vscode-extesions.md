# VS Code Extensions

Este documento detalha quais extensões do Visual Studio Code, recomendadas no arquivo `.vscode/extensions.json`, estão sendo efetivamente utilizadas neste projeto e por quê.

## Extensões em Uso Direto ou Indireto

- **`ms-dotnettools.csdevkit`**, **`ms-dotnettools.csharp`** e **`ms-dotnettools.intellicode-csdevkit`**
  - **Status:** Essenciais e em uso.
  - **Justificativa:** O coração do repositório é o desenvolvimento .NET/C#. Arquivos como `HelloWorld.csproj`, `Program.cs` e a estrutura geral do `Launcher` confirmam isso. Este kit de extensões fornece o suporte fundamental: IntelliSense (autocompletar), depuração, realce de sintaxe e, crucialmente, o gerenciador de soluções para navegar entre os projetos.

- **`eamodio.gitlens`**
  - **Status:** Em uso.
  - **Justificativa:** O projeto é um repositório Git. O `README.md` instrui o usuário a clonar o repositório (`git clone`), e o `versioning-guide.md` detalha um fluxo de trabalho com tags e releases. O GitLens "super-carrega" a integração do Git, permitindo ver o histórico de arquivos, autores de cada linha (blame) e muito mais, o que é extremamente útil.

- **`editorconfig.editorconfig`**
  - **Status:** Em uso.
  - **Justificativa:** A presença do arquivo `.editorconfig` na raiz do projeto confirma que esta extensão está ativa, garantindo que as regras de formatação e estilo de código (espaçamento, quebras de linha, convenções de nomenclatura) sejam aplicadas consistentemente por todos que contribuem.

- **`vscode-icons-team.vscode-icons`**
  - **Status:** Em uso (melhoria de usabilidade).
  - **Justificativa:** A estrutura do repositório, detalhada no `README.md`, é bem organizada e complexa. Esta extensão melhora a navegação visual, atribuindo ícones específicos para cada tipo de arquivo e pasta (`.csproj`, `.sln`, `.cs`, `.md`), tornando mais fácil e rápido identificar os diferentes componentes.

## Extensões Recomendadas para o Futuro do Projeto

Estas são extensões que, embora não haja um arquivo que comprove seu uso *agora*, estão perfeitamente alinhadas com a direção e os objetivos declarados do seu laboratório de estudos.

- **`humao.rest-client`**
  - **Status:** Recomendada para o futuro.
  - **Justificativa:** A estrutura de diretórios no `README.md` planeja uma pasta `src/api/` para "APIs RESTful com ASP.NET Core". Esta extensão será fundamental para testar os endpoints diretamente do VS Code, sem precisar de uma ferramenta externa como o Postman.

- **`ms-dotnettools.polyglot-notebooks`**
  - **Status:** Recomendada para a natureza do projeto.
  - **Justificativa:** O seu repositório é um "Laboratório de Estudos .NET". Esta extensão permite criar "cadernos interativos" onde você pode misturar código C# executável com texto em Markdown. É a ferramenta perfeita para prototipagem, documentação interativa e para criar tutoriais práticos.

## Resumo

| Extensão                              | Utilidade no Projeto                                                                 |
| :------------------------------------ | :----------------------------------------------------------------------------------- |
| `ms-dotnettools.csdevkit`             | **Sim.** Essencial para gerenciar e desenvolver os projetos .NET/C#.                 |
| `ms-dotnettools.csharp`               | **Sim.** Fornece o suporte base para a linguagem C#.                                 |
| `ms-dotnettools.intellicode-csdevkit` | **Sim.** Melhora a produtividade com sugestões de código baseadas em IA.             |
| `eamodio.gitlens`                     | **Sim.** O projeto usa Git para versionamento.                                       |
| `editorconfig.editorconfig`           | **Sim.** Garante a padronização do código com base no arquivo `.editorconfig`.       |
| `vscode-icons-team.vscode-icons`      | **Sim.** Útil para a navegação visual na estrutura de pastas do projeto.             |
| `humao.rest-client`                   | **Ainda não, mas planejado.** Será usada para testar as futuras Web APIs.            |
| `ms-dotnettools.polyglot-notebooks`   | **Provavelmente.** Ideal para a natureza de "laboratório de estudos" do repositório. |

*Este documento deverá ser atualizado ao longo do tempo.*
