# MinimalApi-2

Uma API de exemplo construída com ASP.NET Core que demonstra a criação de controllers, rotas e a interação com modelos simples. Este projeto serve como um ponto de partida para entender os conceitos fundamentais de APIs REST no ecossistema .NET.

## ✨ Features

- **Previsão do Tempo**: Um endpoint que retorna uma lista de previsões do tempo geradas aleatoriamente.
- **Saudações de Usuário**: Endpoints que retornam saudações, tanto genéricas quanto personalizadas.
- **Documentação de API**: Integração com Swagger (OpenAPI) para documentação interativa e testes.

## 🛠️ Tecnologias Utilizadas

- **.NET 9**
- **ASP.NET Core Web API**
- **Swagger (Swashbuckle)**

## 🚀 Como Executar

1. Navegue até o diretório do projeto no seu terminal:

```bash
cd src/api/Apps/MinimalApi-2
```

2. Execute o comando para iniciar a aplicação:

```bash
dotnet run
```

3. A API estará disponível em `http://localhost:5063` (ou na porta configurada no seu `launchSettings.json`).

## 🧪 Como Testar

Você pode testar os endpoints da API de duas maneiras:

1. **Swagger UI**: Navegue para `http://localhost:5063/swagger` no seu navegador para acessar a documentação interativa.
2. **Arquivo `.http`**: Se você usa o Visual Studio Code com a extensão REST Client, abra o arquivo `MinimalApi-2.http` e clique em "Send Request" para testar cada endpoint diretamente do editor.

## Endpoints da API

| Verbo | Rota                       | Descrição                                         |
| :---- | :------------------------- | :------------------------------------------------ |
| `GET` | `/weatherforecast`         | Retorna uma lista de 5 previsões do tempo.        |
| `GET` | `/api/user/greet`          | Retorna uma saudação genérica "Hello, World!".    |
| `GET` | `/api/user/greet/{name}`   | Retorna uma saudação personalizada para o nome fornecido. |
