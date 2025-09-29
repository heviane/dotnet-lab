# Como verificar as dependências do projeto

É fundamental saber verificar as dependências de um projeto.

## 1. Usando o Terminal (Método Recomendado)

A maneira mais rápida e definitiva é usar a linha de comando do .NET.
Navegue até a pasta do seu projeto e execute o seguinte comando:

```bash
dotnet list package
```

O terminal listará todos os pacotes NuGet instalados no projeto. A saída será parecida com esta, e você deve procurar pelas linhas do Microsoft.EntityFrameworkCore:

```textplain
Project 'MinimalApi' has the following package references
   [net9.0]:
   Top-level Package                                      Requested   Resolved
   > Microsoft.EntityFrameworkCore                        8.0.9       8.0.9
   > Microsoft.EntityFrameworkCore.Design                 8.0.9       8.0.9
   > Pomelo.EntityFrameworkCore.MySql                     8.0.2       8.0.2
   > Swashbuckle.AspNetCore                               6.4.0       6.4.0
```

## 2. Verificando o Arquivo de Projeto (.csproj)

O arquivo `.csproj` é a "certidão de nascimento" do seu projeto e lista todas as dependências.

Abra o arquivo na pasta do seu projeto e procure por um `ItemGroup` que contenha `PackageReference`:

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.9" />
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.9" />
  <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
  <!-- Outros pacotes... -->
</ItemGroup>
```

## 3. Através do Visual Studio Code

Se você usa a extensão **C# Dev Kit**, pode ver os pacotes visualmente:

- Na barra lateral do Explorer (explorador de arquivos), você verá a seção Solution Explorer.
- Expanda seu projeto (MinimalApi).
- Expanda a seção Dependencies (Dependências) e, em seguida, Packages (Pacotes).
- Todos os pacotes NuGet instalados estarão listados lá.

## Resumindo, seu projeto já está corretamente configurado com o EF Core. Os métodos acima são ótimos para verificar isso ou qualquer outra dependência no futuro.
