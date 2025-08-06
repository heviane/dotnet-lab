# Projeto `Hello World` do tipo Console

## Instalação do SDK .NET

Verifique se o dotnet está instalado:

```bash  
    dotnet --version
```

Caso não esteja, baixe e instale o SDK .NET no site [https://dotnet.microsoft.com/en-us/](https://dotnet.microsoft.com/en-us/)

## Criar o Projeto `Hello World`

1. Crie o projeto `HelloWorld` via terminal no diretório `src/console`:

```bash
    dotnet new console -o HelloWorld
```

Será criado um diretório chamado `HelloWorld` e dentro a estrutura básica de uma projeto C# para ser executada no terminal.

2. Entre no diretório do projeto

```bash
    cd HelloWorld
```

3. Execute o projeto com o .NET

```bash
    dotnet run
```

## Entendendo os Arquivos do Projeto (Código-Fonte)

Quando o .NET CLI cria o projeto, ele gera alguns arquivos essenciais que formam o código-fonte da sua aplicação.
Estes são os arquivos que **devem** ser versionados com o Git e enviados para o repositório remoto.

- `HelloWorld.csproj`: Este é o arquivo de projeto.
Ele é um XML que define as configurações da sua aplicação, como a versão do .NET que ela usa (Target Framework), dependências (pacotes NuGet) e outras propriedades de compilação. É a "identidade" do seu projeto.

- `Program.cs`: Este é o arquivo de código-fonte principal, escrito em C#.
É aqui que a lógica da sua aplicação reside. Para o nosso projeto inicial, ele contém o código que imprime "Hello, World!" no console.

Esses dois arquivos são a "receita" completa para construir e executar sua aplicação em qualquer máquina que tenha o SDK do .NET instalado.

## Entendendo os Arquivos Gerados (Artefatos de Build)

Ao executar `dotnet run`, o .NET faz duas coisas:

1. **Build (Compilação):** Ele primeiro compila seu código-fonte (`.cs` e `.csproj`) para uma linguagem intermediária que a máquina consegue entender.
2. **Run (Execução):** Em seguida, ele executa o programa compilado.

Durante o processo de compilação, o .NET cria dois diretórios dentro da pasta do seu projeto:

- `obj/`: Contém arquivos de compilação intermediários e temporários. O compilador os utiliza como "rascunhos" para otimizar o processo.
- `bin/`: Contém os arquivos binários finais (o "produto" da compilação). É aqui que fica o executável (`.dll`) da sua aplicação, pronto para ser executado.

### Por que NÃO devemos enviar `bin` e `obj` para o repositório?

Esses diretórios **nunca devem ser enviados para o repositório remoto (Git)**.
Eles são considerados *artefatos de build* e são ignorados de propósito pelo arquivo `.gitignore` do nosso projeto.

Os motivos são:

1. **Redundância:** Qualquer desenvolvedor pode gerar esses arquivos de forma idêntica apenas executando `dotnet build` ou `dotnet run` a partir do código-fonte.
2. **Tamanho:** Arquivos binários são grandes e inflariam o tamanho do repositório desnecessariamente.
3. **Dependência de Ambiente:** Os arquivos compilados podem ser específicos para um sistema operacional ou configuração de máquina. É sempre melhor que cada desenvolvedor compile o código em seu próprio ambiente.

**Regra de ouro:** O repositório deve conter apenas o código-fonte necessário para que outra pessoa possa gerar o programa, e não o programa já gerado.
