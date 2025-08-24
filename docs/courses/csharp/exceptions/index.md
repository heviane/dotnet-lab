# Exceptions

Exceptions são erros ou condições inesperadas que ocorrem durante a execução de um programa. O sistema de tratamento de exceções ajuda a gerenciar esses problemas de forma controlada, evitando que o programa pare abruptamente.

Por exemplo:

- Tentar dividir um número por zero
- Acessar um item de uma lista que não existe
- Tentar abrir um arquivo que foi deletado.

Quando um erro desses acontece, o .NET "lança" (*throws*) uma exception. Se essa exception não for "capturada" (*caught*), o programa irá travar.

## Tratando Exceptions com `try-catch`

A forma mais comum de lidar com exceptions é usando um bloco `try-catch`.

- **`try`**: O código que pode potencialmente lançar uma exception é colocado dentro do bloco `try`.
- **`catch`**: Se uma exception ocorrer dentro do bloco `try`, a execução é transferida para o bloco `catch` correspondente, que contém o código para lidar com o erro.

### Exemplo: Divisão por Zero

```csharp
int a = 10;
int b = 0;

try
{
    // Esta linha vai lançar uma DivideByZeroException
    int resultado = a / b;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (DivideByZeroException ex)
{
    // O código aqui será executado porque a exception foi capturada
    Console.WriteLine("Erro: Não é possível dividir por zero.");
    Console.WriteLine($"Detalhes da exceção: {ex.Message}");
}

Console.WriteLine("O programa continua executando.");
```

No exemplo acima, sem o `try-catch`, o programa travaria. Com ele, a mensagem de erro é exibida e o programa continua sua execução normalmente.

## O Bloco `finally`

Opcionalmente, você pode adicionar um bloco `finally`. O código dentro do `finally` é **sempre** executado, independentemente de uma exception ter ocorrido ou não.

Isso é muito útil para liberar recursos, como fechar arquivos ou conexões de banco de dados, garantindo que ações de limpeza sejam realizadas.

```csharp
try
{
    // Código que pode gerar um erro.
}
catch (Exception ex)
{
    // Lida com o erro.
}
finally
{
    // Este código sempre será executado.
    Console.WriteLine("Bloco finally executado.");
}
```

## Tipos Comuns de Exception

O .NET fornece muitas classes de exception pré-definidas para diferentes tipos de erro:

- **`NullReferenceException`**: Tentativa de usar um objeto que é `null`.
- **`IndexOutOfRangeException`**: Tentativa de acessar um índice de um array ou lista que não existe.
- **`FormatException`**: Um argumento está no formato errado (ex: tentar converter "abc" para um número).
- **`FileNotFoundException`**: Tentativa de acessar um arquivo que não existe.

Você pode capturar tipos específicos de exceptions para tratá-las de maneiras diferentes.

```csharp
try
{
    // ... código que pode gerar diferentes erros ...
}
catch (FormatException ex)
{
    Console.WriteLine("Erro de formato!");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Índice inválido!");
}
catch (Exception ex) // Captura genérica para qualquer outra exceção
{
    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
}
```

> **Boa Prática:** Sempre capture as exceptions mais específicas primeiro e a mais genérica (`Exception`) por último.

## Lançando Exceptions com `throw`

Você também pode criar e lançar suas próprias exceptions usando a palavra-chave `throw`. Isso é útil para sinalizar erros em seus próprios métodos, garantindo que as regras de negócio sejam cumpridas.

```csharp
public void DefinirIdade(int idade)
{
    if (idade < 0)
    {
        // Lança uma exception se a idade for inválida
        throw new ArgumentOutOfRangeException(nameof(idade), "A idade não pode ser negativa.");
    }
    // ... resto da lógica ...
}

try
{
    DefinirIdade(-5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro ao definir idade: {ex.Message}");
}
```
