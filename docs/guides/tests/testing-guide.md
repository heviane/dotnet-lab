# Guia de Testes Automatizados com xUnit

Escrever código que funciona é ótimo, mas garantir que ele **continue funcionando** à medida que o projeto cresce é essencial. É aqui que entram os testes automatizados, um pilar da Fase 3 do nosso roadmap.

Este guia foca em **Testes de Unidade**, que validam a menor parte "testável" de uma aplicação (geralmente um método) de forma isolada.

## 🛠️ Configurando um Projeto de Testes

Usaremos o **xUnit**, um framework de testes popular e gratuito para .NET.

1. **Crie o projeto de testes**: Na raiz da sua solução, execute o comando:

```bash
dotnet new xunit -n MeuProjeto.Tests
```

1. **Adicione o projeto à solução**:

```bash
dotnet sln add MeuProjeto.Tests/MeuProjeto.Tests.csproj
```

3. **Adicione a referência ao projeto que será testado**: Para que o projeto de testes possa "enxergar" as classes do seu projeto principal, adicione uma referência.

```bash
dotnet add MeuProjeto.Tests/MeuProjeto.Tests.csproj reference MeuProjeto/MeuProjeto.csproj
```

## 🧪 Escrevendo seu Primeiro Teste

Os testes de unidade seguem um padrão conhecido como **AAA (Arrange, Act, Assert)**.

- **Arrange (Organizar)**: Configure tudo o que é necessário para o teste. Crie instâncias de classes, prepare os dados de entrada, etc.
- **Act (Agir)**: Execute o método que você quer testar.
- **Assert (Verificar)**: Verifique se o resultado da execução é o esperado.

### Exemplo: Testando uma Classe `Calculator`

```csharp
// Dentro de MeuProjeto.Tests/CalculatorTests.cs

public class CalculatorTests
{
    [Fact] // O atributo [Fact] marca este método como um teste para o xUnit.
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        int numberA = 5;
        int numberB = 10;

        // Act
        int result = calculator.Add(numberA, numberB);

        // Assert
        Assert.Equal(15, result);
    }
}
```

Para executar os testes, basta rodar o comando `dotnet test` na raiz da solução.
