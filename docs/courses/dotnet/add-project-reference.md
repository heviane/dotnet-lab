# Adicionar referência de projeto

## Como adicionar referências

Para adicionar referências de projeto em um projeto .NET, você pode usar o comando `dotnet add reference` no terminal. Siga estes passos:

Abra o terminal na pasta do seu projeto principal (por exemplo, Launcher).
Execute o comando abaixo para cada projeto que deseja referenciar:

```bash
dotnet add reference ../Apps/HelloWorld/HelloWorld.csproj
dotnet add reference ../Apps/Calculator/Calculator.csproj
dotnet add reference ../Apps/Loops/Loops.csproj
dotnet add reference ../Apps/Classes/Classes.csproj
```

Esses comandos vão atualizar automaticamente o arquivo `.csproj` do seu projeto, adicionando as referências necessárias. Assim, seu projeto poderá utilizar o código dos outros projetos referenciados.

Exemplo do rquivo `Launcher.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Apps\HelloWorld\HelloWorld.csproj" />
    <ProjectReference Include="..\Apps\Calculator\Calculator.csproj" />
    <ProjectReference Include="..\Apps\Loops\Loops.csproj" />
    <ProjectReference Include="..\Apps\Classes\Classes.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```
