# 🖥️ Guia: Console Application

Aplicações de console são programas que rodam em um terminal (linha de comando). Elas representam a forma mais pura e fundamental de se programar em .NET.

São ideais para:

- Aprender os fundamentos da linguagem C#.
- Praticar lógica de programação e algoritmos.
- Criar ferramentas de backend e scripts de automação.

---

## 📂 Anatomia de um Projeto de Console

Quando você cria um projeto de console, o .NET gera uma estrutura de arquivos específica. É crucial entender a diferença entre o código que você escreve e os arquivos que o compilador gera.

### Código-Fonte (O que você escreve)

Estes são os arquivos que contêm a "receita" da sua aplicação. Eles **devem** ser versionados com o Git.

- **`<NomeDoProjeto>.csproj`**: O arquivo de projeto. É um XML que define as configurações da sua aplicação, como a versão do .NET (Target Framework) e dependências (pacotes NuGet). Pense nele como a **identidade** do seu projeto.
- **`Program.cs`**: O arquivo de código-fonte principal, escrito em C#. É aqui que a lógica da sua aplicação reside e onde a execução começa.

### Artefatos de Build (O que o .NET gera)

Ao executar `dotnet build` ou `dotnet run`, o .NET compila seu código-fonte e gera arquivos intermediários e executáveis. Estes arquivos **NÃO DEVEM** ser versionados.

- `obj/`: Contém arquivos de compilação temporários que o compilador usa como "rascunho" para otimizar o processo.
- `bin/`: Contém os binários finais (o "produto" da compilação). É aqui que fica o executável (`.dll`) da sua aplicação, pronto para ser executado.

> **Regra de Ouro:** O repositório deve conter apenas o código-fonte necessário para que outra pessoa possa gerar o programa, e não o programa já gerado. É por isso que o arquivo `.gitignore` ignora essas pastas.

---

## 💬 Interagindo com o Usuário

Uma aplicação de console se torna muito mais poderosa quando pode receber dados do usuário. Existem duas formas principais de fazer isso.

### 1. Lendo Dados Durante a Execução

Você pode solicitar que o usuário digite informações enquanto o programa está rodando usando o método `Console.ReadLine()`.

```csharp
// Exemplo em Program.cs
Console.Write("Qual é o seu nome? ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");
```

Este método captura tudo o que o usuário digita até pressionar `Enter` e retorna o resultado como uma string.

### 2. Recebendo Argumentos da Linha de Comando

É possível passar dados para a aplicação no momento em que ela é executada. Esses dados são chamados de "argumentos" e são acessíveis através de uma variável especial `args` que o .NET disponibiliza.

**Como executar com argumentos:**

```bash
# O separador -- é usado para diferenciar os comandos do dotnet dos argumentos da sua aplicação.
dotnet run -- John Doe
```

**Como acessar os argumentos no código:**

```csharp
// Exemplo em Program.cs
Console.WriteLine($"Olá, {args[0]} {args[1]}!");
// Saída esperada: Olá, John Doe!
```

---

## 🚀 Comandos Essenciais

Para uma referência completa dos comandos mais úteis para criar, gerenciar e compilar seus projetos, consulte nosso guia centralizado:

➡️ [Guia de Comandos .NET CLI](../dotnet-cli-guide.md)

---

## 💡 Exemplos Práticos

A melhor forma de aprender é vendo o código em ação. Explore os projetos de console que já criamos:

- [HelloWorld](../../src/console/HelloWorld/README.md): O ponto de partida clássico.
- **(Próximo passo sugerido)**: Crie um projeto `Calculator` que leia dois números do usuário e realize uma operação, aplicando os conceitos de `Console.ReadLine()`.
