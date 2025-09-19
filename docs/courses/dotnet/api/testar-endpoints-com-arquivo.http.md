# Testar o endpoint com o arquivo `.http`

É uma ferramenta de teste muito prática para desenvolvedores.
É um processo bem simples e direto no seu editor de código.

Aqui está o passo a passo, assumindo que você está usando o **Visual Studio Code** com a extensão **REST Client** (o processo é muito similar no Visual Studio ou Rider, que já possuem essa funcionalidade nativa).

## Passo a Passo para Testar a API

### 1. Inicie a sua API

Primeiro, você precisa ter a API **HelloWorld** rodando.
Abra um terminal, navegue até a pasta do projeto:

```bash
cd src/api/Apps/HelloWorld
```

Execute o comando para iniciar a API e deixá-la "escutando" por alterações:

```bash
dotnet watch run
```

O terminal mostrará uma mensagem indicando que a aplicação está rodando e em qual endereço, algo como: Now listening on: http://localhost:5040. Anote essa porta.

### 2. Verifique a Porta no Arquivo `.http`

Abra o arquivo `HelloWorld.http.`
Confira se o valor da variável `@HelloWorld_HostAddress` corresponde à porta que sua API está usando.
Se a sua API iniciou na porta 5123, por exemplo, você deve ajustar a linha:

```http
@HelloWorld_HostAddress = http://localhost:5123
```

No seu caso, o padrão é 5040, que provavelmente estará correto.

### 3. Envie a Requisição

Com o arquivo `HelloWorld.http` aberto no VS Code, você verá um link de texto `Send Request` que aparece logo acima da linha `GET {{HelloWorld_HostAddress}}/weatherforecast/.`

Clique em `Send Request`.

### 4. Analise a Resposta

Imediatamente, uma nova aba/painel se abrirá à direita, mostrando a resposta completa do servidor.

Você verá algo assim:

O Status da Resposta: HTTP/1.1 200 OK (indicando sucesso).
Os Cabeçalhos (Headers) da resposta.
O Corpo (Body) da resposta, que será um JSON com a lista de previsões do tempo, parecido com isto:

```json
[
  {
    "date": "2024-09-20",
    "temperatureC": 35,
    "temperatureF": 94,
    "summary": "Hot"
  },
  {
    "date": "2024-09-21",
    "temperatureC": 12,
    "temperatureF": 53,
    "summary": "Cool"
  },
  // ... mais 3 itens
]
```

> **E é isso!** Você acabou de testar sua API diretamente do editor, de forma rápida e eficiente. Você pode adicionar mais requisições (como POST ou PUT para o TaskManager) no mesmo arquivo, separando-as com `###`.
