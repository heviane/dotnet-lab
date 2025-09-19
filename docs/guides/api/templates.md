# Templates de APIs disponivel no .NET

O .NET oferece diferentes templates para iniciar o desenvolvimento de uma API, cada um com um propósito específico:

- **Minimal API (`webapiminimal`)**: Uma abordagem mais moderna e simplificada, introduzida no .NET 6. Permite criar endpoints diretamente no arquivo `Program.cs` com o mínimo de código. É excelente para microserviços e APIs rápidas e leves.
- **Web API (`webapi`)**: O template tradicional e mais completo, baseado no padrão MVC (Model-View-Controller). Utiliza classes `Controller` para organizar os endpoints. É ideal para APIs maiores e mais complexas.
- **gRPC Service (`grpc`)**: Template para criar serviços de alta performance usando o framework gRPC (Google Remote Procedure Call). É uma ótima escolha para comunicação eficiente entre microserviços em um ambiente interno.
