# 🖥️ Projetos de Console

Bem-vindo à área de projetos de console do Laboratório de Estudos .NET. Este diretório contém todas as aplicações de linha de comando desenvolvidas como parte da trilha de aprendizado.

O objetivo é criar estudos práticos e isolados, cada um focando em um conceito específico da plataforma .NET, e gerenciá-los através de uma aplicação central chamada `Launcher`.

---

## 📂 Estrutura dos Projetos

A organização dos projetos foi pensada para ser simples e escalável:

```
console/
├── 🚀 Launcher/
│   ├── Program.cs         # O código do menu principal
│   └── Launcher.csproj    # O arquivo de projeto do Launcher
│
├── 📁 Apps/
│   ├── Calculator/        # Projeto de estudo: Calculadora
│   ├── Loops/             # Projeto de estudo: Desafios de Loops
│   └── ...                # Outros projetos de estudo
│
└── 📄 README.md            # Este arquivo que você está lendo
```

-   **`Launcher`**: É a aplicação principal e o ponto de entrada para todos os outros estudos de console. Ele apresenta um menu interativo que permite escolher e executar qualquer um dos projetos listados.
-   **`Apps/`**: Este diretório contém as aplicações de console individuais. Cada subpasta representa um estudo, aula ou desafio específico, mantendo o código de cada lição organizado e independente.

---

## 🚀 Como Executar

Para explorar os estudos, você não precisa executar cada projeto individualmente. Basta iniciar o `Launcher` a partir do diretório raiz do repositório.

Execute o seguinte comando no seu terminal:

```bash
dotnet run --project src/console/Launcher/Launcher.csproj
```

Isso irá compilar e executar o `Launcher`, que exibirá o menu com todos os projetos de estudo disponíveis para execução.

---

## ✨ Como Adicionar um Novo Estudo

Para adicionar uma nova aplicação de console ao `Launcher`, siga estes três passos:

1.  **Crie o Novo Projeto**: Use a CLI do .NET para criar seu novo projeto de console dentro da pasta `Apps`.

    ```bash
    dotnet new console -o src/console/Apps/MeuNovoEstudo
    ```

2.  **Adicione a Referência no Launcher (Opcional, mas recomendado)**: Adicionar a referência ajuda o .NET a entender a relação entre os projetos.

    ```bash
    dotnet add src/console/Launcher/Launcher.csproj reference src/console/Apps/MeuNovoEstudo/MeuNovoEstudo.csproj
    ```

3.  **Adicione ao Menu do Launcher**: Abra o arquivo `src/console/Launcher/Program.cs` e adicione seu novo projeto à lista `projects`.

    ```csharp
    var projects = new List<Project>
    {
        // ... outros projetos
        new Project("Meu Novo Estudo", "../Apps/MeuNovoEstudo/MeuNovoEstudo.csproj")
    };
    ```

Pronto! Na próxima vez que você executar o `Launcher`, seu novo estudo aparecerá como uma opção no menu.
