# Anatomia de um Projeto .NET

Todo projeto .NET, seja uma aplicação de console, uma API ou uma biblioteca, segue uma estrutura de arquivos padrão. Entender o propósito de cada arquivo e diretório é fundamental para navegar, desenvolver e gerenciar suas aplicações de forma eficaz.

Vamos dissecar a estrutura usando um projeto de console como exemplo, pois ele contém os elementos essenciais.

---

## 🏗️ A Estrutura Essencial

Ao criar um novo projeto, você encontrará uma estrutura parecida com esta:

```text
MeuProjeto/
├── 📂 obj/
├── 📂 bin/
├── 📂 Properties/
│   └── 📄 launchSettings.json
├── 📄 MeuProjeto.csproj
└── 📄 Program.cs
```

Esses arquivos e pastas podem ser divididos em duas categorias:

- **Código-fonte** (o que você escreve)
- **Artefatos de build** (o que o compilador gera).

---

### Código-Fonte (O que você escreve)

Estes são os arquivos que contêm a "receita" da sua aplicação. Eles definem o comportamento, a configuração e a identidade do seu projeto. **Estes arquivos devem sempre ser versionados com o Git.**

#### `MeuProjeto.csproj`

Este é o **arquivo de projeto**. É um arquivo XML que funciona como a "carteira de identidade" do seu projeto. Ele informa ao .NET e ao Visual Studio:

- **Qual tipo de projeto é**: Console, Web API, Class Library, etc.
- **Qual versão do .NET usar (Target Framework)**: Ex: `<TargetFramework>net8.0</TargetFramework>`.
- **Quais pacotes NuGet (dependências) ele utiliza**.
- **Outras configurações de compilação**.
- Contém informações referente a build, debug, testes, etc...

#### `Program.cs`

Este é o **ponto de entrada** da sua aplicação. É o primeiro arquivo de código C# que é executado. Em projetos modernos, ele geralmente usa "top-level statements", o que significa que você pode escrever seu código diretamente no arquivo, sem precisar de uma classe `Program` ou um método `Main` explícito.

```csharp
// Program.cs
Console.WriteLine("Olá, Mundo!"); // A execução começa aqui.
```

#### `Properties/launchSettings.json`

Este arquivo contém configurações sobre **como iniciar seu projeto localmente**. Ele é usado pelo Visual Studio e pelo comando `dotnet run` para definir:

- **Perfis de execução**: Por exemplo, um para rodar como aplicação de console e outro para rodar com o debugger do Visual Studio.
- **Variáveis de ambiente**: Útil para configurar strings de conexão ou chaves de API apenas no ambiente de desenvolvimento.
- **Argumentos de linha de comando** a serem passados na inicialização.

**Importante**: Este arquivo é destinado apenas para o ambiente de desenvolvimento local e geralmente não é usado em produção.

> **OBS**: Este arquivo não é criado em projetos do tipo `Class Library` (bibliotecas de classes), pois estes não possuem configuração de execução direta.

---

### Artefatos de Build (O que o .NET gera)

Ao executar `dotnet build` ou `dotnet run`, o compilador do .NET (Roslyn) entra em ação. Ele pega seu código-fonte e o transforma em um programa executável. Os arquivos gerados nesse processo são chamados de "artefatos de build".

> **Regra de Ouro:** Estes arquivos **NÃO DEVEM** ser versionados com o Git. Eles são gerados a partir do código-fonte, e o arquivo `.gitignore` padrão do .NET já os ignora.

#### `obj/` (Objects)

Este diretório contém **arquivos intermediários e temporários** que o compilador usa durante o processo de build. Pense nele como um "rascunho" que ajuda a otimizar e a acelerar compilações futuras. Você raramente (ou nunca) precisará interagir com esta pasta.

#### `bin/` (Binaries)

Este diretório contém o **resultado final da compilação**: os binários da sua aplicação. É aqui que você encontrará:

- **`MeuProjeto.dll`**: A biblioteca de vínculo dinâmico (DLL) que contém o código compilado da sua aplicação. Este é o principal artefato.
- **`MeuProjeto.exe`** (no Windows): Um executável que roda a sua DLL.
- **`MeuProjeto.deps.json`**: Um arquivo que lista todas as dependências do projeto.
- **`MeuProjeto.runtimeconfig.json`**: Um arquivo que define as configurações de tempo de execução, como a versão do .NET necessária para rodar a aplicação.

Em resumo, a pasta `bin` contém tudo o que é necessário para **executar** sua aplicação em uma máquina que tenha o .NET Runtime instalado.
