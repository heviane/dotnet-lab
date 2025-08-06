# Projeto `Hello World` do tipo Console

## Instalação do SDK .NET

1. Verifique se o dotnet está instalado:

```bash  
    dotnet --version
```

caso não esteja, baixe e instale o SDK .NET no site [https://dotnet.microsoft.com/en-us/](https://dotnet.microsoft.com/en-us/)

## Criar o Projeto `Hello World`

- Crie o projeto `HelloWorld` no diretório `/src` via terminal:

```bash
    cd /src # Se estiver na raiz do repositório
    dotnet new console -o HelloWorld-macOS
```

Será criado um diretório chamado `HelloWorld` e dentro a estrutura básica de uma projeto C# para ser executada no terminal.

- Entre no diretório do projeto

```bash
    cd HelloWorld-macOS
```

- Execute o projeto com o .NET

```bash
    dotnet run
```

Por padrão, quando criamos um projeto `.NET` de console já é criado o arquivo **Program.cs** que é o arquivo principal.
E o mesmo já possui o código necessário para exibir o texto “Hello World” na tela, então após a execução dos comandos acima veremos o texto **“Hello World”** sendo impresso no nosso terminal.
