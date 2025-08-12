# Aula 01: Escrevendo seu primeiro código C# via Console

Este documento corresponde às anotações do primeiro módulo de aprendizado, focado em criar e executar uma aplicação de console básica.

Para executar código C#, ele precisa ser compilado dentro de um projeto .NET.

## Criar um novo projeto

Essencialmente, você precisa:

1. Criar um novo projeto de **"Console Application"**.
2. Colocar seu código no arquivo **Program.cs** gerado.
3. Usar o comando `dotnet run` para compilar e executar.

Vamos ao passo a passo:

### Passo 1: Criar um Novo Projeto

Abra seu terminal, navegue até o diretório onde deseja criar o projeto (por exemplo, dentro de **src/console/**) e execute o seguinte comando para criar um projeto chamado **HelloWorld**:

```bash
dotnet new console -o HelloWorld
```

### Passo 2: Navegar para o Diretório do Projeto

Entre na pasta que o comando acabou de criar:

```bash
cd HelloWorld
```

Dentro desta pasta, você encontrará um arquivo chamado **Program.cs**.

### Passo 3: Adicionar o Código e Executar

O arquivo Program.cs já virá com um "Hello, World!". Você pode abri-lo em um editor de texto e verá algo assim:

```csharp
// Program.cs
Console.WriteLine("Hello, World!");
```

Agora, para executar, basta usar o comando:

```bash
dotnet run
```

Você verá a saída **Hello, World!** no seu terminal.

## Executar um Projeto Existente

Se você já tem um projeto criado, você pode executá-lo diretamente da raiz do repositório com o comando:

```bash
dotnet run --project src/console/HelloWorld/HelloWorld.csproj
```

## References

- [https://learn.microsoft.com/pt-br/training/modules/csharp-write-first/](https://learn.microsoft.com/pt-br/training/modules/csharp-write-first/)
