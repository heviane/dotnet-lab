# Executar o container do SQL Server em background

Comando completo e comentado para iniciar um contêiner do SQL Server que continuará rodando em segundo plano:

```bash
docker run -d \
    -e "ACCEPT_EULA=Y" \
    -e "SA_PASSWORD=Your_Strong_Password" \
    -p 1433:1433 \
    --name sql-server-dev \
    mcr.microsoft.com/mssql/server:2022-latest
```

O que cada parte do comando faz?

docker run: O comando para criar e iniciar um novo contêiner.
-d: A flag --detach. É ela que instrui o Docker a rodar o contêiner em segundo plano. O terminal ficará livre imediatamente após a execução.
-e "ACCEPT_EULA=Y": Uma variável de ambiente obrigatória para aceitar os termos de licença do SQL Server.
-e "SA_PASSWORD=...": Define a senha para o usuário sa (system administrator). Use uma senha forte aqui.
-p 1433:1433: Mapeia a porta 1433 do contêiner para a porta 1433 da sua máquina local (host), permitindo que sua API se conecte a ele.
--name sql-server-dev: Dá um nome amigável ao contêiner. Isso facilita gerenciá-lo depois (ex: docker stop sql-server-dev).
mcr.microsoft.com/...: O nome da imagem oficial do SQL Server que será baixada e usada.
