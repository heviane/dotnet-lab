# 🌐 Projetos de Web API

Bem-vindo à área de projetos de Web API do Laboratório de Estudos .NET. Este diretório é dedicado a aplicações que expõem funcionalidades pela web, seguindo os princípios de APIs RESTful.

O objetivo é criar estudos práticos e isolados, cada um focando em conceitos específicos do desenvolvimento de backend com ASP.NET Core, como a criação de endpoints, integração com bancos de dados usando Entity Framework, e boas práticas de arquitetura.

---

## 📂 Estrutura dos Projetos

A organização dos projetos foi pensada para ser simples e escalável:

```textplain
api/
├── 📁 Apps/
│   ├── ECommerce/         # Projeto de estudo: API para um E-commerce
│   ├── TaskManager/       # Projeto de estudo: Gerenciador de Tarefas
│   └── ...                # Outros projetos de estudo
│
└── 📄 README.md            # Este arquivo que você está lendo
```

- **`Apps/`**: Este diretório contém as aplicações de API individuais. Cada subpasta representa um estudo, aula ou desafio específico, mantendo o código de cada lição organizado e independente.

---

## 🚀 Como Executar

Para explorar os estudos, você pode executar cada projeto individualmente a partir do diretório raiz do repositório.

Execute o seguinte comando no seu terminal, substituindo `NomeDoProjeto` pelo nome da API que deseja iniciar:

```bash
dotnet run --project src/api/Apps/NomeDoProjeto/NomeDoProjeto.csproj
```

Isso irá compilar e executar a API. Por padrão, ela estará disponível em `https://localhost:5001` ou `http://localhost:5000`.

Você pode então interagir com os endpoints usando:

- O seu navegador.
- Ferramentas como Postman ou Insomnia.
- A extensão REST Client para VS Code.

---

## ✨ Como Adicionar um Novo Estudo

Para adicionar uma nova Web API, siga estes dois passos:

1. **Crie o Novo Projeto**: Use a CLI do .NET para criar seu novo projeto de API dentro da pasta `Apps`.

- Template `webapi` é o mais recomendado.

```bash
dotnet new webapi -o src/api/Apps/MinhaNovaApi
```

1. **Execute a Nova API**: Compile e execute o projeto recém-criado. Você pode fazer isso de duas maneiras:

- **Execução Simples**: Use `dotnet run` para compilar e iniciar a API uma vez.

```bash
# A partir do diretório raiz do repositório
dotnet run --project src/api/Apps/MinhaNovaApi/MinhaNovaApi.csproj
```

- **Execução com "Hot Reload" (Recomendado para Desenvolvimento)**: Use `dotnet watch run` para que o .NET monitore seus arquivos. A cada alteração salva, a API é automaticamente reiniciada.

```bash
# Navegue até a pasta do novo projeto
cd src/api/Apps/MinhaNovaApi

# Execute com o "watcher"
dotnet watch run
```

Pronto! Sua nova API já está rodando e pronta para ser desenvolvida. Diferente dos projetos de console, não há um `Launcher` central; cada API é um ponto de entrada independente.
