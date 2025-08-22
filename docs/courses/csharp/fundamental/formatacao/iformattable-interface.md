# A Interface IFormattable: O Coração da Formatação em C#

Você já se perguntou como é possível formatar um número como moeda (`meuDecimal:C`) ou uma data em um formato específico (`minhaData:dd/MM/yyyy`)? A "mágica" por trás disso é a interface `IFormattable`.

## O que é IFormattable?

`IFormattable` é uma interface fundamental no .NET que fornece um mecanismo para formatar o valor de um objeto em uma representação de string personalizada. Qualquer tipo que implementa esta interface pode ser formatado usando:

1. **Strings de formato**: Códigos como "C" (moeda), "P" (percentual), "N2" (número com 2 casas decimais), "yyyy-MM-dd" (data), etc.
2. **Provedores de formato**: Objetos que fornecem informações de formatação específicas de uma cultura (como `CultureInfo`), definindo se o separador decimal é `.` ou `,`, qual o símbolo da moeda, etc.

## A Assinatura da Interface

A interface `IFormattable` é surpreendentemente simples. Ela define apenas um método:

```csharp
string ToString(string format, IFormatProvider formatProvider);
```

- **`format`**: Uma string que especifica o formato desejado. Se for `null` ou vazia, o formato geral (padrão) do tipo deve ser usado.
- **`formatProvider`**: Um objeto que fornece informações de formatação cultural. Geralmente, é uma instância de `CultureInfo`.

Quando você escreve `valor.ToString("C")` ou usa a interpolação `{valor:C}`, o compilador, nos bastidores, chama uma versão de `ToString` que eventualmente usa a cultura atual como `formatProvider`.

## Exemplo Prático: Criando um Tipo Formatável

Vamos ver como funciona criando nossa própria classe que implementa `IFormattable`. Criaremos uma classe `Temperature` que pode ser exibida em Celsius, Fahrenheit ou Kelvin.

```csharp
using System;
using System.Globalization;

public class Temperature : IFormattable
{
    private decimal temp;

    public Temperature(decimal temperature)
    {
        this.temp = temperature;
    }

    // Método da interface IFormattable
    public string ToString(string format, IFormatProvider formatProvider)
    {
        // Se nenhum formato for fornecido, use 'C' (Celsius) como padrão.
        if (string.IsNullOrEmpty(format)) format = "C";

        // Usa o formatProvider padrão se nenhum for fornecido.
        if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

        switch (format.ToUpperInvariant())
        {
            case "C": // Celsius
                return temp.ToString("F2", formatProvider) + " °C";
            case "F": // Fahrenheit
                return ((temp * 9 / 5) + 32).ToString("F2", formatProvider) + " °F";
            case "K": // Kelvin
                return (temp + 273.15m).ToString("F2", formatProvider) + " K";
            default:
                throw new FormatException($"O formato '{format}' não é suportado.");
        }
    }

    // Sobrescrevendo o ToString() padrão para um comportamento simples
    public override string ToString()
    {
        return this.ToString("C", CultureInfo.CurrentCulture);
    }
}
```

### Como Usar

```csharp
var temp = new Temperature(25.123m);

Console.WriteLine($"Temperatura Padrão: {temp}");         // Usa o ToString() padrão
Console.WriteLine($"Temperatura em Fahrenheit: {temp:F}"); // Usa o IFormattable
Console.WriteLine($"Temperatura em Kelvin: {temp:K}");     // Usa o IFormattable
```

## Conclusão

A interface `IFormattable` é o pilar que permite a formatação rica e flexível em .NET. Todos os tipos que você já formatou (`int`, `double`, `decimal`, `DateTime`, `DateTimeOffset`, `Guid`, `Enum`, etc.) implementam esta interface.

Entendê-la ajuda a desmistificar como a formatação funciona e abre a porta para criar seus próprios tipos de dados que se integram perfeitamente ao sistema de formatação do C#.
