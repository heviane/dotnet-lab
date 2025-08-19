# Testando a API pela Primeira Vez

## Interface do Swagger (OpenAPI)

Para verificar se a estrutura básica está funcionando, execute a API e acesse a documentação interativa do Swagger.

> A interface do Swagger (OpenAPI) vem pré-configurada no template criado (web api .NET).
> Ela permite que você visualize e interaja com sua API diretamente pelo navegador.

1. **Navegue até a pasta da API e execute-a**:

```bash
cd src/Stock.API
dotnet run
```

2. **Acesse o Swagger no Navegador**: O terminal mostrará as URLs em que a aplicação está rodando (uma HTTP e outra HTTPS). Abra a URL **HTTPS** (ex: `https://localhost:7123/swagger`) no seu navegador.

### ⚠️ Solução de Problemas Comuns

Ao acessar a URL `https://` pela primeira vez, o navegador pode exibir um aviso de segurança ("Sua conexão não é particular") ou uma tela em branco (comum no Safari). Isso acontece porque o certificado de desenvolvimento local não é confiável por padrão.

**A solução recomendada** é executar o seguinte comando (uma única vez) no seu terminal para que sua máquina confie no certificado do .NET:

```bash
dotnet dev-certs https --trust
```

Após executar o comando, reinicie a API com `dotnet run` e atualize a página no navegador.
