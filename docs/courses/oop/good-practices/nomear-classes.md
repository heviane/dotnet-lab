# Boas Práticas: Nomear Classes

A regra geral e a melhor prática é que os nomes das classes devem ser sempre no singular.

**Por que no singular?**
Uma classe é um molde ou um blueprint para criar objetos. Cada objeto é uma instância única dessa classe.

Se você tem uma classe Pessoa, ela descreve as características e comportamentos de uma única pessoa. Quando você cria new Pessoa(), você está criando uma pessoa.
Se você tem uma classe Produto, ela descreve um único produto.
Usar o singular torna o código mais intuitivo e legível, pois o nome da classe reflete a natureza de uma única entidade que ela representa.

**Exemplos:**

- **Correto**: Pessoa, Cliente, Pedido, Livro, Carro
- **Incorreto (geralmente)**: Pessoas, Clientes, Pedidos, Livros, Carros

### Exceções e Nuances

Embora a regra seja "singular", há algumas situações onde nomes plurais ou que descrevem um conjunto podem ser apropriados:

- **Classes que representam Coleções**: Se a classe em si é uma coleção especializada de objetos.

**Ex**: ListaDeProdutos, CarrinhoDeCompras (que contém múltiplos itens).

No entanto, é mais comum usar as coleções genéricas do .NET (como `List<T>`, `Dictionary<TKey, TValue>`) e nomear a variável da coleção no plural, por exemplo: `List<Pessoa> pessoas;`.

- **Classes de Serviço ou Gerenciamento**: Classes que orquestram operações sobre múltiplos objetos de um tipo.

**Ex:** GerenciadorDeUsuarios, ServicoDePedidos.
Nesses casos, o nome descreve a função da classe, que pode envolver múltiplas entidades.

- **Classes de Utilitário ou Agrupamento de Funcionalidades**: Classes que agrupam métodos estáticos ou funcionalidades relacionadas.

Seu exemplo FormatStrings se encaixa aqui. Ela não representa uma "FormatString", mas sim um conjunto de funcionalidades relacionadas à formatação de strings. O nome FormatStrings é perfeitamente aceitável e descritivo para esse propósito.

**Ex:**: MathUtils (utilitários matemáticos).

### Conclusão

Mantenha a convenção de usar nomes de classes no singular para representar entidades individuais. Para classes que agrupam funcionalidades ou representam coleções, use nomes que descrevam claramente o propósito do agrupamento, que podem ser plurais ou descritivos. Sua abordagem atual está muito boa e alinhada com as melhores práticas!
