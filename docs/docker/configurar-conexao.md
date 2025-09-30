# Configurar a conexão com o Banco de Dados SQL Server

Abaixo, um exemplo de como a string de conexão para o SQL Server deve ser adicionada ao arquivo `appsettings.Development.json` ou `appsettings.json` dependendo do ambiente:

```json
{
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=NomeDoSeuBanco;Trusted_Connection=True;"
}
}
```

> **Nota sobre Docker**: Se você estiver executando o SQL Server em um contêiner Docker, a string de conexão acima **não funcionará**. Você deve usar a Autenticação SQL e o endereço de rede exposto pelo contêiner. A conexão correta seria semelhante a esta:

```json
{
    "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=NomeDoSeuBanco;User Id=sa;Password=Your_Strong_Password;TrustServerCertificate=True;"
    }
}
```

> Lembre-se de substituir `Your_Strong_Password` pela senha `sa` que você definiu ao criar o contêiner.
