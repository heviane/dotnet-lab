# Remover blocos de código de instruções if

Os desenvolvedores de software adoram quando podem escrever código que salva pressionamentos de teclas e espaço visual sem sacrificar a legibilidade. Aplique apenas a frase "menos é mais" no processo de desenvolvimento quando ele torna seu código mais legível e compreensível.

Se o bloco de código precisar de apenas uma linha, é provável que você não precise definir um bloco formal usando chaves. Embora tecnicamente você nem precise separar seu código em várias linhas, a combinação de instruções em uma única linha pode dificultar a leitura do código.

Remover as chaves conforme descrito acima é uma alteração de estilo que não deve afetar a funcionalidade do código. No entanto, você deve tomar medidas para garantir que suas alterações não impactem negativamente o quão legível o código é. Você pode avaliar o impacto da remoção das chaves e dos espaços em branco e reverter para o código original se achar que as alterações tornaram seu código menos legível.

```csharp
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
```

```csharp
bool flag = true;
if (flag)
    Console.WriteLine(flag);
```

> **Observação:** Remover as chaves não altera o fato de que `Console.WriteLine(flag);` é o bloco de código da instrução `if`.

## Examinar a legibilidade das instruções 'if' em formato de linha única

Nesta etapa, você examinará um caso em que a legibilidade do código pode ser afetada negativamente.

Como a instrução `if` e a chamada do método `Console.WriteLine()` são curtas, você pode ser tentado a combiná-las em uma única linha. Afinal, a sintaxe C# da `if` instrução permite que você combine instruções dessa maneira.

```csharp
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
```

```csharp
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
```

> Observe o quanto é mais fácil ler o segundo exemplo de código.

## Recapitulação

Aqui estão algumas coisas importantes a serem lembradas sobre legibilidade e blocos de código de instruções if:

- Se você perceber que tem apenas uma linha de código listada nos blocos de código de uma instrução if-elseif-else, remova as chaves e o espaço em branco do bloco de código. A Microsoft recomenda que as chaves sejam usadas de modo consistente em todos os blocos de código das instruções if-elseif-else presentes no código, seja incluindo ou omitindo as chaves em todas as ocorrências semelhantes.
- Só remova as chaves de um bloco de código quando isso tornar o código mais legível. A inclusão de chaves é sempre aceitável.
- Só remova o feed de linha se ele torna o código mais legível. A Microsoft sugere que seu código será mais legível quando cada instrução for colocada em sua própria linha de código.
