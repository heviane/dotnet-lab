# Interagir via terminal com o Banco de Dados SQL Server

A maneira mais direta de interagir com o SQL Server via terminal, especialmente quando ele está rodando em um contêiner Docker, é usando a ferramenta de linha de comando sqlcmd, que já vem instalada dentro do próprio contêiner.

Você pode executar um terminal interativo dentro do seu contêiner sql-server-dev para se conectar ao banco de dados.

## Passo a Passo para se Conectar

> **Pré-requisito**: Certifique-se de que o seu contêiner `sql-server-dev` está em execução. Você pode verificar com o comando `docker ps`. Se ele não estiver na lista, inicie-o com `docker start sql-server-dev`.

### 1.Execute o Comando de Conexão

Abra seu terminal e execute o seguinte comando. Ele vai iniciar o sqlcmd dentro do contêiner que já está rodando.

```bash
docker exec -it sql-server-dev /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P 'Your_Strong_Password' -C
```

- **docker exec -it sql-server-dev**: Executa um comando de forma interativa (-it) dentro do contêiner chamado sql-server-dev.
O comando `docker exec` serve para "executar" um processo dentro de um contêiner que já está rodando. Se o contêiner estiver parado, o Docker não terá onde executar o comando `sqlcmd` e retornará um erro.
- **/opt/mssql-tools18/bin/sqlcmd**: O caminho para o executável sqlcmd dentro do contêiner.
- **-S localhost**: O servidor a se conectar (do ponto de vista de dentro do contêiner, o servidor é ele mesmo, ou localhost).
- **-U sa**: O usuário (sa).
- **-P 'Your_Strong_Password'**: A senha que você definiu. Lembre-se de substituir pela sua senha real!
- **-C**: Instrui o cliente a confiar no certificado do servidor, mesmo que seja autoassinado.
Flag para confiar no certificado do servidor, evitando erros de SSL com certificados autoassinados (comum em ambientes de desenvolvimento com Docker).

### 2.Interaja com o Banco de Dados

Se a conexão for bem-sucedida, seu prompt mudará para `1>`. Agora você pode executar comandos SQL.

Importante: Cada lote de comandos deve ser finalizado com `GO` em uma nova linha para ser executado.

Exemplo de sessão:

```sql
-- Verifica a versão do SQL Server
SELECT @@VERSION;
GO -- Executa o comando

-- Lista todas as tabelas do banco de dados atual
SELECT name FROM sys.databases WHERE database_id > 4;
GO

-- Cria um novo banco de dados para testes
CREATE DATABASE MyTestDB;
GO

-- Muda o contexto para o novo banco de dados
USE MyTestDB;
GO

-- Verifica o banco de dados atual
SELECT DB_NAME();
GO

-- Cria uma tabela simples
CREATE TABLE Products (ID int, Name nvarchar(50));
GO

-- Insere um dado
INSERT INTO Products VALUES (1, 'Pen');
GO

-- Consulta os dados
SELECT * FROM Products;
GO

-- Para sair do sqlcmd
QUIT
```
