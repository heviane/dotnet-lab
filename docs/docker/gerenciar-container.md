# Gerenciar Container do Banco de Dados SQL Server

Como gerenciar o contêiner em background?

Para verificar se está rodando:

```bash
docker ps
```

Para ver os logs (útil para depuração):

```bash
docker logs sql-server-dev
```

Para parar o contêiner:

```bash
docker stop sql-server-dev
```

Para iniciar novamente um contêiner já existente:

```bash
docker start sql-server-dev
```
