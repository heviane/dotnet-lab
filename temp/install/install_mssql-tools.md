# Instalação do mssql-tools

**mssql-tools** é um pacote de ferramentas de linha de comando da Microsoft que permite que você se conecte e interaja com um banco de dados SQL Server diretamente do seu terminal.

Ele inclui principalmente duas ferramentas:

1. **sqlcmd**: O utilitário mais comum, usado para executar consultas SQL, rodar scripts e gerenciar o banco de dados. É a forma como você "conversa" com o SQL Server sem precisar de uma interface gráfica.
2. **bcp**: Uma ferramenta para importar e exportar grandes volumes de dados de/para o banco de dados de forma muito rápida.

Em resumo, se você precisa automatizar tarefas ou simplesmente gerenciar o SQL Server via terminal (especialmente em ambientes como macOS e Linux), o mssql-tools é o pacote essencial para isso.

## Instalação via Terminal com Homebrew

1. **Adicione o repositório da Microsoft (Tap)**: Este comando adiciona o repositório oficial da Microsoft ao seu Homebrew, permitindo que ele encontre os pacotes do SQL Server.

```bash
brew tap microsoft/mssql-release https://github.com/Microsoft/homebrew-mssql-release
```

2. **Instale as ferramentas**: Este comando fará o download e a instalação do mssql-tools e de sua dependência, o driver ODBC (msodbcsql18).

```bash
brew install mssql-tools18
```

3. **Adicione as ferramentas ao seu PATH (Recomendado)**: Para poder usar o comando sqlcmd de qualquer lugar no seu terminal, é uma boa prática adicionar o diretório de instalação ao seu PATH.

```bash
echo 'export PATH="/opt/homebrew/bin:$PATH"' >> ~/.zshrc
source ~/.zshrc
```

**Nota**:

- Este comando é para o `Zsh`, o `shell` padrão nas versões mais recentes do macOS.
- Se você usa `Bash`, substitua `~/.zshrc` por `~/.bash_profile`.

4. **Verifique a instalação**: Após a conclusão, você pode verificar se a instalação foi bem-sucedida executando:

```bash
sqlcmd -?   # bash
sqlcmd -\?  # zsh
```

Se o comando exibir as opções de ajuda do `sqlcmd`, significa que a instalação foi concluída com sucesso!
