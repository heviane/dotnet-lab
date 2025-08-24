# Formatação Personalizada de Data e Hora

A capacidade de formatação em C# não se limita a números. Vários outros tipos de dados importantes também implementam a interface `IFormattable`, permitindo um controle preciso sobre sua representação em string.

## Formatação com Especificadores de Formato Padrão para DateTime

```csharp
DateTime agora = DateTime.Now;

Console.WriteLine($"Data e hora atual: {agora}\n");

Console.WriteLine($"'d' (Data curta): {agora:d}"); // 25/10/2023
Console.WriteLine($"'D' (Data longa): {agora:D}"); // Thursday, October 25, 2023
Console.WriteLine($"'t' (Hora curta): {agora:t}"); // 14:30:55
Console.WriteLine($"'T' (Hora longa): {agora:T}"); // 14:30:55:000
Console.WriteLine($"'f' (Data/hora completa curta): {agora:f}"); // 25/10/2023 14:30:55
Console.WriteLine($"'F' (Data/hora completa longa): {agora:F}"); // Thursday, October 25, 2023 14:30:55:000
Console.WriteLine($"'g' (Data/hora geral curta): {agora:g}"); // 10/25/23 2:30:55 PM
Console.WriteLine($"'G' (Data/hora geral longa): {agora:G}"); // Thursday, October 25, 2023 2:30:55 PM
Console.WriteLine($"'o' (Padrão ISO 8601): {agora:o}"); // 2023-10-25T14:30:55
Console.WriteLine($"'s' (Padrão classificável): {agora:s}"); // Thursday, October 25, 2023 2:30:55 PM
```

## Formatação com Especificadores de Formato Personalizados para DateTime

A formatação de datas e horas é extremamente flexível e poderosa. Você pode combinar diversos especificadores para criar praticamente qualquer formato de data/hora que precisar.

**Principais Especificadores:**

- `dd`: Dia do mês (01-31)
- `MM`: Mês (01-12)
- `yyyy`: Ano com 4 dígitos
- `yy`: Ano com 2 dígitos
- `HH`: Hora no formato 24h (00-23)
- `hh`: Hora no formato 12h (01-12)
- `mm`: Minutos (00-59)
- `ss`: Segundos (00-59)
- `tt`: Designador AM/PM
- `ddd`: Nome do dia da semana abreviado (ex: "seg")
- `dddd`: Nome do dia da semana completo (ex: "segunda-feira")

```csharp
using System.Globalization;

DateTime agora = DateTime.Now;

// Formato padrão brasileiro
Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm:ss"));
// Saída Exemplo: 25/10/2023 14:30:55

// Formato americano com nome do mês
Console.WriteLine(agora.ToString("MMMM dd, yyyy"));
// Saída Exemplo (en-US): October 25, 2023

// Formato ISO 8601 (muito usado em APIs)
Console.WriteLine(agora.ToString("yyyy-MM-ddTHH:mm:ss"));
// Saída Exemplo: 2023-10-25T14:30:55

// Formato personalizado com dia da semana
var culturaBR = new CultureInfo("pt-BR");
Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy", culturaBR));
// Saída Exemplo: quarta-feira, 25 de outubro de 2023
```
