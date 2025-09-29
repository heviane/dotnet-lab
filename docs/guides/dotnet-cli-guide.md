# Guia para Comandos .NET CLI

A **Interface de Linha de Comando (CLI) do .NET** é a principal ferramenta para criar, gerenciar, compilar e executar aplicações .NET diretamente do seu terminal. Ela é multiplataforma e essencial para um fluxo de trabalho de desenvolvimento moderno.

Este guia reúne os comandos mais úteis para a sua jornada de aprendizagem.

---

## 📂 Gerenciamento de Projetos (`.csproj`)

Estes comandos são usados para interagir diretamente com um arquivo de projeto (`.csproj`).

| Comando | Descrição |
| :--- | :--- |
| `dotnet new <TEMPLATE>` | Cria um novo projeto a partir de um template. Ex: `dotnet new console -o MeuApp`. |
| `dotnet new list` | Lista todos os templates de projeto disponíveis na sua máquina. |
| `dotnet new search <TERMO>` | Procura por templates no NuGet. Útil para encontrar templates da comunidade. |
| `dotnet run` | Compila e executa o projeto a partir do diretório atual. |
| `dotnet build` | Compila o projeto e suas dependências em um conjunto de binários. |
| `dotnet test` | Executa os testes de um projeto de teste. |
| `dotnet publish` | Compila e publica a aplicação para implantação, criando os arquivos necessários. |
| `dotnet clean` | Limpa os artefatos de compilação (arquivos das pastas `bin` e `obj`). |

---

## 📦 Gerenciamento de Soluções (`.sln`)

Estes comandos são usados para gerenciar um arquivo de solução (`.sln`), que agrupa múltiplos projetos.

| Comando | Descrição |
| :--- | :--- |
| `dotnet new sln` | Cria um novo arquivo de solução (`.sln`) no diretório atual. |
| `dotnet sln add <PROJETO>` | Adiciona um ou mais projetos ao arquivo de solução. |
| `dotnet sln remove <PROJETO>` | Remove um projeto do arquivo de solução. |
| `dotnet sln list` | Lista todos os projetos contidos no arquivo de solução. |

---

## 🧩 Gerenciamento de Pacotes (NuGet)

Estes comandos são usados para adicionar, remover e listar bibliotecas de terceiros (pacotes NuGet) em um projeto.

| Comando | Descrição |
| :--- | :--- |
| `dotnet add package <PACOTE>` | Adiciona um pacote NuGet ao projeto. |
| `dotnet remove package <PACOTE>` | Remove um pacote NuGet do projeto. |
| `dotnet list package` | Lista todos os pacotes NuGet referenciados no projeto. |

### ⬆️ Como Atualizar um Pacote?

A CLI do .NET não possui um comando direto como `dotnet update`. A forma mais comum de atualizar um pacote é executando o comando `add` novamente, especificando a versão desejada:

```bash
# Atualiza o pacote para a versão mais recente
dotnet add package <NomeDoPacote>

# Atualiza o pacote para uma versão específica
dotnet add package <NomeDoPacote> --version <VERSAO_ESPECIFICA>
```

Para verificar pacotes desatualizados, uma ferramenta muito popular na comunidade é a `dotnet-outdated-tool`.

1. **Instalar a ferramenta (apenas uma vez):**

```bash
    dotnet tool install --global dotnet-outdated-tool
```

2. **Verificar pacotes desatualizados no seu projeto:**

```bash
    dotnet outdated
 ```
