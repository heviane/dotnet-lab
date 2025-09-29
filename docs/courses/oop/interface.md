# Interface

Interface é, fundamentalmente, um conceito da Programação Orientada a Objetos (POO), especificamente um pilar da **Abstração**.

Embora o C# forneça a palavra-chave interface como sua implementação concreta desse conceito, a ideia de definir um "contrato" de comportamento sem especificar a implementação é um princípio universal da POO.

É um tipo de referência que define um "contrato" de funcionalidades que uma `class` ou `struct` pode implementar.

Uma interface é um contrato que pode ser implementado por uma classe.
É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.
Assim como uma classe abstrata, uma interface não pode ser instanciada.
Quando falamos de interface, não falamos em herdar, mas sim em implementar.
Uma classe pode implementar várias interfaces (multiplas implementações).

Exemplo:

- Interface *ICalculadora*: Possui métodos sem implementações, pois são somente contratos. Na prática, significa que toda classe que implementa uma interface deverá obrigatoriamente implementar esses métodos.
- Classe *CalculadoraComum*
- Classe *CalculadoraCientifica*

- **Conceito de POO**: A interface permite que você defina um conjunto de métodos, propriedades, eventos ou indexadores que uma classe ou struct deve implementar. Ela estabelece um "contrato" que as classes que a implementam devem seguir, garantindo que elas possuam certas funcionalidades. Isso promove a abstração (focar no "o que" um objeto faz, não no "como") e o polimorfismo (tratar objetos de diferentes tipos de forma uniforme se eles implementarem a mesma interface).
- **Implementação em C#**: O C# oferece a palavra-chave interface para criar esses contratos. Classes e structs podem então implementar uma ou mais interfaces, comprometendo-se a fornecer a implementação para todos os membros definidos na interface.
Portanto, é um conceito de POO que é implementado e utilizado extensivamente em C#.

## Exemplo

Uma interface não pode ser instanciada, mas pode-se fazer isso:

```csharp
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Sum(3,5));
```

Também podemos implementar um método padrão na interface, assim como, em uma classe abstrata.
