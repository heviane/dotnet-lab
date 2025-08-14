# Trabalhar com mais de um projeto

## Passo a passo

1. Criar o projeto principal **Launcher**

    ```bash
        dotnet new console -o src/console/Launcher
    ```

2. Adicionar as referências aos outros projetos que serão executados pelo projeto principal

    ```bash
    cd src/console/Launcher
    dotnet add reference ../Calculator
    dotnet add reference ../Loops
    dotnet add reference ../Classes
    ```

    O arquivo de projeto **.csproj** deve ser atualizado automaticamente com a execução dos comandos acima:

    ```xml
    <Project Sdk="Microsoft.NET.Sdk">

    <ItemGroup>
        <ProjectReference Include="..\Calculator\Calculator.csproj" />
        <ProjectReference Include="..\Loops\Loops.csproj" />
        <ProjectReference Include="..\Classes\Classes.csproj" />
    </ItemGroup>

    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net9.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
    </PropertyGroup>

    </Project>
    ```
