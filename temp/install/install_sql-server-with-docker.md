# Plano de Ação: Usando SQL Server com Docker

1. **Instale o Docker Desktop**: Se ainda não o tiver, baixe e instale o Docker Desktop para o seu sistema operacional.

2. **Inicie o Contêiner do SQL Server**: Abra seu terminal e execute o seguinte comando. Ele fará o download da imagem do SQL Server 2022 e iniciará um contêiner.

```bash
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<SUA-SENHA>' -p 1433:1433 --name <SEU-DB> -d mcr.microsoft.com/mssql/server:2022-latest
```

- Análise do Comando:
**-e "ACCEPT_EULA=Y"**: Aceita os termos de licença.
**-e "SA_PASSWORD=yourStrong(!)Password"**: Importante! Defina uma senha forte para o usuário sa. A senha precisa atender aos requisitos de complexidade do SQL Server.
**-p 1433:1433**: Mapeia a porta 1433 do seu computador para a porta 1433 do contêiner, permitindo que sua API se conecte a ele.
**--name <SEU-DB>**: Dá um nome fácil de lembrar ao seu contêiner.
**-d**: Executa o contêiner em modo "detached" (em segundo plano).
**mcr.microsoft.com/mssql/server:2022-latest**: A imagem oficial do SQL Server.

## Como acessar o banco de dados via apllicação

- **Atualize sua String de Conexão**: Agora, sua API precisa saber como se conectar a este banco de dados. No arquivo `appsettings.Development.json` do seu projeto `Stock.API`, a string de conexão será muito simples:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=<SEU-DB>;User Id=sa;Password=<SUA-SENHA>;TrustServerCertificate=True"
  }
}
```

- **TrustServerCertificate=True** é importante para o desenvolvimento local com Docker, pois o certificado SSL do contêiner não é confiável por padrão.

## Como acessar o banco de dados por fora da apllicação

Agora que o contêiner está rodando, você pode acessar o banco de dados SQL Server de várias formas:

### Usando Azure Data Studio ou DBeaver (GUI)

Baixe e instale Azure Data Studio ou DBeaver.
Abra o programa e crie uma nova conexão.
Use os seguintes dados:

- **Servidor/Host**: localhost
- **Porta**: 1433
- **Usuário**: sa
- **Senha**: <SUA-SENHA>

Clique em conectar.

### Usando o terminal com o sqlcmd (CLI)

Se você tiver o utilitário `sqlcmd` instalado, execute:

```bash
sqlcmd -S localhost -U sa -P '<SUA-SENHA>' -N -C
```

Para instruir o `sqlcmd` a confiar no certificado autoassinado do servidor. adicionamos dois flags ao seu comando:

**-N**: Força a criptografia da conexão.
**-C**: (O mais importante) Instrui o cliente a confiar no certificado do servidor (TrustServerCertificate).

As versões mais novas do driver ODBC da Microsoft (que o sqlcmd usa) agora são seguras por padrão.

Isso significa que:

- **A Criptografia é Habilitada por Padrão**: O cliente tenta estabelecer uma conexão segura (criptografada) com o servidor.
- **A Validação do Certificado é Exigida**: O cliente verifica se o certificado SSL apresentado pelo servidor (o SQL Server no Docker) foi emitido por uma Autoridade Certificadora (CA) confiável.
- **O contêiner Docker do SQL Server usa um certificado autoassinado (self-signed) para a criptografia**. Como ele não foi emitido por uma CA confiável, a validação falha, e a conexão é recusada com o erro que você viu.

Se não tiver, instale o pacote `mssql-tools`: [install_mssql-tools.md](./install_mssql-tools.md).

### Usando o próprio contêiner Docker

Você pode abrir um terminal dentro do contêiner e usar o `sqlcmd`:

```bash
-docker exec -it <SEU-DB> /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P '<SUA-SENHA>'
+docker exec -it <SEU-DB> bash
+# Dentro do contêiner, execute:
+/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P '<SUA-SENHA>'
```

Assim, você terá acesso ao prompt do SQL Server para executar comandos SQL diretamente.

## Como verificar o acesso

Você sabe que está conectado ao SQL Server quando o prompt do seu terminal muda e passa a exibir `1>`.

```plaintext
1>
```

Este é o **prompt interativo** do `sqlcmd`, indicando que ele está aguardando seus comandos `T-SQL`. O número 1 significa que ele está pronto para a primeira linha de comando do seu lote.

**Como fazer um teste rápido?**

Para ter 100% de certeza e executar sua primeira consulta, faça o seguinte:

No prompt `1>`, digite o comando para verificar a versão do SQL Server e pressione Enter:

```sql
SELECT @@VERSION;
```

O prompt mudará para `2>`. Agora, digite `GO` e pressione **ENTER**:

```sql
GO
```

O comando `GO` instrui o `sqlcmd` a enviar o lote de comandos que você digitou para o servidor. Você deverá ver uma saída detalhada com as informações da versão do SQL Server 2022, confirmando que tudo está funcionando.

Para sair do `sqlcmd` e voltar ao seu terminal normal, basta digitar `QUIT` e pressionar **ENTER**.

## Comandos Úteis no `sqlcmd`

Aqui estão alguns comandos básicos para você começar a gerenciar o SQL Server. Lembre-se de sempre digitar `GO` em uma nova linha para executar o lote de comandos.

### Listar todas as bases de dados

Para ver todas as bases de dados existentes na instância do SQL Server, use o seguinte comando:

```sql
SELECT name FROM sys.databases;
GO
```

### Criar uma nova base de dados

Para criar o banco de dados `<SEU-DB>` que será usado pela nossa aplicação, execute:

```sql
CREATE DATABASE avanade;
GO
```

Após a execução, você pode verificar se o banco de dados foi criado listando todas as bases novamente. O banco `<SEU-DB>` deve aparecer na lista.

> **Solução de Problemas: "Invalid cursor state"**
> Se em algum momento você receber o erro `SqlState 24000, Invalid cursor state`, significa que o cliente `sqlcmd` se perdeu no estado da conexão. A solução mais simples é sair da sessão com `QUIT` e reconectar-se. Isso inicia uma sessão limpa e geralmente resolve o problema.
