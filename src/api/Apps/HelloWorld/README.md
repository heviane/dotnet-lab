# Projeto: HelloWorld API

Este é um projeto de **Web API** simples que demonstra como usar **Controllers** para criar endpoints.

---

## 🎯 Objetivo

O objetivo deste projeto é servir como um ponto de partida para entender conceitos de APIs baseadas em Controllers, como:

- Configuração e inicialização de uma aplicação web.
- Criação de um `Controller` com múltiplos endpoints (`Actions`).
- Integração automática com a documentação Swagger (OpenAPI).

---

## ✅ Pré-requisitos

Antes de executar, certifique-se de que você tem o **SDK do .NET** instalado. Para mais detalhes sobre o ambiente, consulte o guia principal do repositório:

- 📄 Guia de Requisitos

---

## 🚀 Como Executar

Você pode executar este projeto de duas maneiras. A forma mais recomendada é navegar até a pasta do projeto e usar o comando `watch` para que a API reinicie automaticamente após cada alteração no código.

```bash
cd src/api/Apps/HelloWorld
dotnet watch run
```

Após a execução, a API estará disponível nos seguintes endereços (a porta pode variar):

- **Endpoint**: `http://localhost:<porta>/weatherforecast`
- **Documentação Swagger**: `http://localhost:<porta>/swagger`

---

## 📂 Estrutura do Projeto

Os arquivos essenciais deste projeto são:

- `Program.cs`: O ponto de entrada da aplicação. Responsável por configurar os serviços (como o Swagger e os Controllers) e o pipeline de requisições HTTP.
- `Controllers/`: Criado Controllers para definir os endpoints.
- `Models/`: Criado Models para representar os dados.
