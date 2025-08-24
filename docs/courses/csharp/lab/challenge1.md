# Desáfios para Console Application

...

## Gerencie a entrada do usuário durante esse desafio

Ao usar uma instrução Console.ReadLine() para obter a entrada do usuário, é prática comum utilizar uma cadeia de caracteres do tipo anulável (designada string?) para a variável de entrada e, em seguida, avaliar o valor inserido pelo usuário. O código de exemplo a seguir utiliza uma cadeia de caracteres do tipo anulável para capturar a entrada do usuário. A iteração continuará enquanto o valor fornecido pelo usuário for nulo:

```csharp
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
```

A expressão booliana avaliada pela instrução while pode ser utilizada para garantir que a entrada do usuário atenda a um requisito especificado. Por exemplo, se um prompt solicitar que o usuário insira uma cadeia de caracteres que inclua pelo menos três caracteres, o código a seguir poderá ser utilizado:

```csharp
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```

Se você desejar utilizar a entrada Console.ReadLine() para valores numéricos, precisará converter o valor da cadeia de caracteres para um tipo numérico.

O método int.TryParse() pode ser utilizado para converter um valor de cadeia de caracteres em um número inteiro. O método utiliza dois parâmetros, uma cadeia de caracteres que será avaliada e o nome de uma variável inteira à qual será atribuído um valor. O método retorna um valor Booliano. O código de exemplo a seguir demonstra o uso do método int.TryParse():

```csharp
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
```

Se o valor da cadeia de caracteres atribuído a readResult representar um número inteiro válido, o valor será atribuído à variável de número inteiro chamada numericValue e true será atribuído à variável booliana denominada validNumber. Se o valor atribuído a readResult não representar um número inteiro válido, validNumber receberá um valor de false. Por exemplo, se readResult for igual a "7", o valor 7 será atribuído a numericValue.
