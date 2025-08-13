# Projeto: HelloWorld

Este é um projeto de **Console Application** simples, criado para servir como o primeiro exemplo prático no ecossistema .NET.

## 🎯 Objetivo

O objetivo deste projeto é demonstrar a estrutura mínima de uma aplicação de console em C# e servir como ponto de partida para entender os comandos básicos da .NET CLI.

## ✅ Pré-requisitos

Antes de executar, certifique-se de que você tem o **SDK do .NET** instalado. Para mais detalhes sobre o ambiente, consulte o guia principal do repositório:

- 📄 [Requisitos para o Ambiente de Desenvolvimento](../../../docs/requirements-guide.md)

## 🚀 Como Executar

Você pode executar este projeto de duas maneiras a partir do diretório raiz do repositório:

1. **Executando diretamente o projeto (recomendado):**

    ```bash
    dotnet run --project src/console/HelloWorld/HelloWorld.csproj
    ```

2. **Navegando até a pasta e executando:**

    ```bash
    cd src/console/HelloWorld
    dotnet run
    ```

    Ambos os comandos irão compilar e executar a aplicação, e você deverá ver a seguinte saída no seu terminal: `Hello, World!`

## 📂 Estrutura do Projeto

Os arquivos essenciais deste projeto são:

- `HelloWorld.csproj`: O arquivo de projeto. Ele define as configurações da aplicação, como a versão do .NET que ela usa (Target Framework). É a "identidade" do projeto.
- `Program.cs`: O arquivo de código-fonte principal, escrito em C#. É aqui que a lógica da aplicação reside. Para este projeto, ele contém apenas uma linha que escreve "Hello, World!" no console.

> Para uma explicação mais detalhada sobre a estrutura de arquivos de um projeto de console, incluindo os diretórios `bin` e `obj`, consulte o [Guia de Console Application](../../../docs/console/README.md)
