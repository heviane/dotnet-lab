# NuGet

Nuget é o **gerenciador de pacotes oficial do .NET**.

## O que é um PACOTE?

Na prática, um pacote é um arquivo compactado (geralmente com a extensão `.nupkg`) que contém uma ou mais bibliotecas compiladas (arquivos `.dll`), metadados e outros ativos necessários.

A definição mais técnica e completa, no contexto do **gerenciador de pacotes NuGet**, é que *um pacote é um conjunto de arquivos que são agrupados para facilitar o compartilhamento e a reutilização*.

Ele é projetado para incluir tudo o que é necessário para usar a biblioteca em seu projeto, como:

- **Código Compilado**: Os arquivos .dll que contêm o código que você vai usar.
- **Manifesto (`.nuspec`)**: Um arquivo XML que descreve o conteúdo do pacote, incluindo seu nome, versão, autor, licença e, mais importante, suas dependências. As dependências listam outros pacotes que são necessários para que este pacote funcione.
- **Arquivos de Conteúdo**: Outros arquivos de suporte, como arquivos de documentação, arquivos de configuração ou scripts.

Em outras palavras, o pacote é a unidade de distribuição. Em vez de lidar com arquivos individuais, você lida com o pacote como um todo, e o NuGet se encarrega de extrair, instalar e gerenciar todos os componentes para você. Isso padroniza a forma como as bibliotecas são compartilhadas e consumidas no ecossistema .NET.

## O que é o NuGet?

O NuGet é é uma ferramenta essencial para qualquer desenvolvedor, pois automatiza o processo de adicionar, remover e atualizar bibliotecas e dependências em seus projetos.

Pense no NuGet como a sua "loja de aplicativos" para bibliotecas de código. Em vez de baixar arquivos `.dll` manualmente da internet e gerenciar as dependências por conta própria, o NuGet faz tudo isso por você.

## Como o NuGet funciona?

- **Repositório Centralizado**: A maioria dos pacotes NuGet é hospedada no repositório público em [nuget.org](https://nuget.org). Este é o maior repositório de pacotes, mas você também pode ter repositórios privados na sua empresa.
- **Pacotes**: Um pacote NuGet é um arquivo comprimido (`.nupkg`) que contém o código compilado (`DLLs`), arquivos de manifesto (`.nuspec`) e outras informações necessárias.
- **Comandos**: Você interage com o NuGet através do Visual Studio ou da linha de comando (CLI do .NET).

## Por que o NuGet é tão importante?

- **Reuso de Código**: Ele permite que você use rapidamente bibliotecas de terceiros ou bibliotecas internas da sua organização, como por exemplo:
  - Entity Framework Core para acesso a dados;
  - NUnit para testes;
  - Serilog para logging.
- **Gerenciamento de Dependências**: O NuGet resolve automaticamente as dependências. Se o pacote A depende do pacote B, ele garantirá que ambos sejam instalados com as versões corretas.
- **Versionamento**: Você pode especificar a versão exata de um pacote que seu projeto precisa, garantindo que o seu código seja sempre compilado com a versão esperada.
- **Consistência**: Garante que todos os desenvolvedores de uma equipe estejam usando as mesmas versões de bibliotecas, evitando problemas de compatibilidade.

## Como instalar e verificar o NuGet?

Uma dúvida comum é "como eu instalo o NuGet?". A resposta é simples: **você não precisa instalar o NuGet separadamente!**

O NuGet é uma parte fundamental do ecossistema .NET e **já vem incluído no .NET SDK** (Software Development Kit). Ao instalar o SDK, todas as ferramentas do NuGet (via linha de comando `dotnet`) já estão prontas para uso.

### Verificando a Instalação

Para verificar se o NuGet está disponível, basta confirmar se o .NET SDK está instalado. Abra seu terminal e execute:

```bash
dotnet --version
```

Se este comando retornar um número de versão (ex: `8.0.300`), significa que o .NET SDK e, consequentemente, o NuGet, estão instalados e prontos para serem usados.

## Como usar o NuGet?

### Via Linha de Comando (CLI do .NET)

- Adicionar um pacote: `dotnet add package NomeDoPacote`
  - Exemplo: `dotnet add package Newtonsoft.Json --version 13.0.4-beta1`
- Instalar todos os pacotes de um projeto: `dotnet restore`
- Atualizar um pacote: `dotnet add package NomeDoPacote --version 8.0.0`
- Remover um pacote: `dotnet remove package NomeDoPacote`

> **OBS:** Os comandos devem ser executados dentro de um projeto .NET.

### Via Visual Studio

No Visual Studio, você pode gerenciar pacotes através da interface do usuário: "Gerenciar Pacotes NuGet" (botão direito no seu projeto no Gerenciador de Soluções). Por lá, você pode pesquisar, instalar, atualizar e remover pacotes.

## RESUMO

O NuGet é uma ferramenta indispensável que simplifica enormemente a gestão de dependências, permitindo que você se concentre na lógica do seu negócio, em vez de se preocupar em como obter e manter as bibliotecas necessárias.

## References

- [nuget.org](https://www.nuget.org)
