# Formatação Numérica Personalizada

Além dos formatos padrão (`C`, `N`, `P`, etc.), o C# permite criar strings de formato personalizadas para controlar com precisão como os números são exibidos. Isso é útil para atender a requisitos específicos de relatórios, interfaces de usuário ou exportação de dados.

A formatação personalizada é feita usando uma combinação de especificadores de formato.

## 1. O Especificador `0` (Zero Placeholder)

O `0` atua como um espaço reservado para um dígito. Se o número que está sendo formatado não tiver um dígito na posição onde o `0` aparece, um zero será exibido em seu lugar.

- **Uso:** Forçar um número mínimo de dígitos, especialmente para zeros à esquerda ou à direita.

```csharp
double numero = 8.5;

// Força a exibição de 3 dígitos antes da vírgula e 2 depois
Console.WriteLine(numero.ToString("000.00")); // Saída: 008,50

int inteiro = 5;
// Garante que o número tenha pelo menos 4 dígitos
Console.WriteLine(inteiro.ToString("0000")); // Saída: 0005
```

---

## 2. O Especificador `#` (Digit Placeholder)

O `#` também é um espaço reservado para um dígito, mas ele só exibe o dígito se ele estiver presente no número. Zeros à esquerda ou à direita desnecessários não são exibidos.

- **Uso:** Exibir números de forma limpa, sem zeros extras.

```csharp
double numero1 = 8.5;
Console.WriteLine(numero1.ToString("###.##")); // Saída: 8,5

double numero2 = 1234.567;
Console.WriteLine(numero2.ToString("###.##")); // Saída: 1234,57 (ocorre arredondamento)

int inteiro = 5;
Console.WriteLine(inteiro.ToString("####")); // Saída: 5
```

---

## 3. O Especificador `.` (Ponto Decimal)

Determina a posição do separador decimal na string resultante. O caractere real exibido (`.` ou `,`) depende da `CultureInfo` atual.

```csharp
int valor = 123;
// Formata como um valor com duas casas decimais
Console.WriteLine(valor.ToString("0.00")); // Saída (pt-BR): 123,00
```

---

## 4. O Especificador `,` (Separador de Milhar)

Indica que o número deve ser formatado com separadores de grupo (milhar, milhão, etc.). A posição exata e o caractere usado dependem da `CultureInfo`.

- **Uso:** Melhorar a legibilidade de números grandes.

```csharp
long numeroGrande = 1234567890;
Console.WriteLine(numeroGrande.ToString("#,##0")); // Saída (pt-BR): 1.234.567.890
```

**Nota:** Para que o separador de milhar funcione, ele deve ser colocado entre especificadores de dígito (`0` ou `#`).

---

## 5. O Especificador `;` (Separador de Seção)

Permite definir até três formatos diferentes em uma única string, separados por ponto e vírgula.

1. **Primeira seção:** Formato para números positivos.
2. **Segunda seção:** Formato para números negativos.
3. **Terceira seção:** Formato para o valor zero.

```csharp
double positivo = 123.45;
double negativo = -123.45;
double zero = 0;

string formato = "#,##0.00;(#,##0.00);'Zero'";

Console.WriteLine(positivo.ToString(formato)); // Saída: 123,45
Console.WriteLine(negativo.ToString(formato)); // Saída: (123,45)
Console.WriteLine(zero.ToString(formato));     // Saída: Zero
```

---

## 6. O Especificador `%` (Símbolo de Porcentagem)

Quando usado em uma string de formato personalizada, o especificador `%` multiplica o número por 100 e insere o símbolo de porcentagem (`%`) na posição em que aparece.

```csharp
double taxa = 0.075;
// O número é multiplicado por 100
Console.WriteLine(taxa.ToString("0.0%")); // Saída: 7,5%
```

---

## 7. Literais na String de Formato

Você pode incluir texto literal na sua string de formato envolvendo-o com aspas simples (`' '`) ou duplas (`" "`).

```csharp
int temperatura = 23;
Console.WriteLine(temperatura.ToString("'Temperatura atual:' ##'°C'")); // Saída: Temperatura atual: 23°C

decimal preco = 49.99m;
Console.WriteLine(preco.ToString("'Preço:' R$ #,##0.00")); // Saída: Preço: R$ 49,99
```
