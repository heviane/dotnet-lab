# Notes 👀

## Tipos de Projetos

```text
└── 💻 src/                      # Projetos e aplicações práticas.
    ├── console/                 # Aplicações de linha de comando (Console)
    ├── api/                     # APIs RESTful com ASP.NET Core (Web API)
    ├── app/                     # Aplicações Web com UI (MVC/Razor Pages)
    ├── blazor/                  # Aplicações Web interativas com Blazor
    ├── console/                 # Aplicações de linha de comando (Console)
    ├── library/                 # Bibliotecas de código reutilizável (Class Library)
    ├── maui/                    # Aplicações nativas (Desktop/Mobile) com .NET MAUI
    └── tests/                   # Projetos de testes automatizados (xUnit, etc.)
    └── worker/                  # Serviços de background e tarefas agendadas
```

Últimas adições, com uma breve explicação do porquê são relevantes para iniciantes:

- Worker Service (worker): Este é o modelo ideal para criar serviços de background. Pense em tarefas que precisam rodar continuamente ou em intervalos agendados, como processar e-mails em uma fila, gerar relatórios noturnos ou monitorar um recurso. Para um iniciante, é um passo natural depois de um aplicativo de console, introduzindo conceitos importantes como o Host Genérico e Injeção de Dependência em um contexto mais simples que o de uma API web.

- Blazor (blazor): Enquanto **MVC** e **Razor Pages** são ótimos para aplicações web tradicionais, **Blazor** é a tecnologia da Microsoft para criar interfaces web interativas e ricas com C#. Em vez de depender majoritariamente de JavaScript, você pode construir componentes de UI reutilizáveis usando a linguagem que já está aprendendo. É fundamental para quem quer desenvolver aplicações web modernas no ecossistema .NET.

- .NET MAUI (maui): Este é o framework para criar **aplicativos nativos para desktop (Windows, macOS) e mobile (iOS, Android)** a partir de uma única base de código C#. Para um iniciante que sonha em criar um aplicativo para celular ou um programa para instalar no computador, o MAUI é o caminho moderno e oficial dentro da plataforma .NET.

## Sugestões de conteúdos

- Crie um novo arquivo em `docs/` chamado `blazor-vs-mvc.md` explicando as diferenças entre Blazor e MVC para um iniciante.

- **string verbatim**, prefixada com o símbolo `@`.
Uma string verbatim ignora todas as sequências de escape, tratando cada caractere como um literal.
- conversão de tipo implícita e explícita

## References

Links para pesquisar e descobrir...

- [https://www.mkdocs.org](https://www.mkdocs.org)
