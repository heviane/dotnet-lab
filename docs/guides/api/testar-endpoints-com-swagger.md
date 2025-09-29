# Testar Endpoints com a Documentação Swagger

A documentação interativa gerada pelo **Swagger (OpenAPI)** é uma das ferramentas mais poderosas no ecossistema ASP.NET Core. Ela não apenas documenta sua API, mas também fornece uma interface de usuário (UI) para testar cada endpoint diretamente do navegador, sem a necessidade de ferramentas externas como Postman ou arquivos `.http`.

## Passo a Passo para Testar com a Swagger UI

### 1. Inicie a sua API

Assim como em outros métodos de teste, o primeiro passo é garantir que sua API esteja rodando.

Abra um terminal e navegue até a pasta de um dos projetos de API (usaremos o `HelloWorld` como exemplo):

```bash
cd src/api/Apps/HelloWorld
```

Execute o comando para iniciar a API:

```bash
dotnet watch run
```

O terminal informará o endereço onde a aplicação está rodando, como `http://localhost:5040`.

### 2. Acesse a Documentação Swagger

Abra seu navegador de preferência.
Navegue até o endereço da sua aplicação, adicionando `/swagger` ao final da URL.

**Exemplo:** `http://localhost:5040/swagger`

Você verá a página principal do Swagger, listando todos os controllers e endpoints da sua API.

### 3. Explore e Selecione um Endpoint

A UI organiza os endpoints agrupados por seus `Controllers`. No projeto `HelloWorld`, você verá os grupos `WeatherForecast` e `User`.
Clique na barra de um endpoint para expandir seus detalhes. Vamos usar o `GET /weatherforecast` como exemplo.

### 4. Execute um Teste

1. **Habilite o modo de teste:** Dentro do painel expandido do endpoint, clique no botão **"Try it out"**. Isso tornará a seção de parâmetros (se houver) editável e habilitará o botão de execução.

2. **Execute a requisição:** Como o endpoint `GET /weatherforecast` não exige parâmetros, basta clicar no botão azul **"Execute"**.

### 5. Analise a Resposta

Logo abaixo do botão "Execute", a Swagger UI exibirá a resposta completa do servidor.

* **Curl & Request URL:** Mostra o comando `curl` equivalente e a URL exata que foi chamada.
* **Server response:** Esta é a parte mais importante.
  * **Code:** O código de status HTTP retornado (ex: `200` para sucesso).
  * **Response body:** O corpo da resposta, geralmente em formato JSON.

Você verá um JSON com a previsão do tempo, semelhante a este:

```json
[
  {
    "date": "2024-09-20",
    "temperatureC": 35,
    "temperatureF": 94,
    "summary": "Hot"
  },
  // ... mais itens
]
```

### Testando um Endpoint com Parâmetros

Para testar um endpoint como `GET /api/user/greet/{name}`:

1. Expanda o endpoint e clique em **"Try it out"**.
2. Um campo de texto aparecerá na seção **"Parameters"** para você preencher o valor de `name`.
3. Digite um nome (ex: "Heviane") e clique em **"Execute"**.
4. A resposta mostrará a saudação personalizada.

> **E é isso!** A Swagger UI simplifica enormemente o ciclo de desenvolvimento e teste, permitindo validar o comportamento da sua API de forma rápida e visual.

## References

* Especificação Swagger/OpenAPI: [https://swagger.io/](https://swagger.io/)
