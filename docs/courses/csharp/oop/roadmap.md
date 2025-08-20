# 🏛️ Roadmap: Programação Orientada a Objetos (POO)

A Programação Orientada a Objetos é um paradigma fundamental no desenvolvimento de software moderno e uma habilidade essencial para qualquer desenvolvedor .NET.

---

## 🧱 Módulo 1: A Base da POO

O ponto de partida. Aqui, você entenderá o que são objetos, como eles são construídos e como interagem.

- 💡 **Classes e Objetos**: Entender o que é um "molde" (`Classe`) e o que é uma "instância" (`Objeto`). A base de tudo.
  - **Composição**: Como objetos podem ser compostos por outros objetos (`Course` contém uma lista de `Pessoa`).

- 🔩 **Membros de uma Classe**: Os blocos de construção de um objeto.
  - **Propriedades**: Como um objeto armazena e expõe dados (`{ get; set; }`, *backing fields*, `=>`).
  - **Métodos**: Como um objeto executa ações (métodos de instância vs. estáticos).
  - **Construtores**: Como um objeto é inicializado (`new()`, construtores parametrizados, inicializadores de objeto).

- 🔑 **Modificadores de Acesso**: Controlando a visibilidade e introduzindo o **Encapsulamento**.
  - `public`: Acessível de qualquer lugar.
  - `private`: Acessível apenas dentro da própria classe.
  - `protected`: Acessível dentro da classe e em classes derivadas (subclasses).

---

## 🏛️ Módulo 2: Os 4 Pilares da POO

Estes são os princípios que dão poder, flexibilidade e organização ao seu código.

- 💊 **Encapsulamento**: Proteger os dados de um objeto e expor apenas as operações seguras. É o princípio de "esconder a complexidade".

  > É o ato de "empacotar" dados (campos) e os métodos que os manipulam dentro de uma única unidade (a classe). O acesso aos dados é controlado por meio de uma interface pública (propriedades e métodos `public`), enquanto os detalhes internos permanecem ocultos (`private`).
  >
  > **Exemplo:** Você dirige um carro usando o volante e os pedais (`interface pública`), sem precisar saber como o motor ou a transmissão funcionam (`detalhes privados`). Isso protege o motor de uso indevido e simplifica a direção.

- 👨‍👩‍👧 **Herança**: Reutilizar código e criar hierarquias de classes, onde uma classe filha herda características de uma classe pai (`base`, `derived`, `sealed`).

  > Permite que uma nova classe (derivada ou filha) herde atributos e métodos de uma classe existente (base ou pai). Isso promove a reutilização de código e estabelece uma relação "é um" (um `Carro` é um `Veiculo`).
  >
  > **Como funciona?**
  > - **`:`**: Usado para indicar que uma classe herda de outra. Ex: `class Carro : Veiculo`.
  > - **`base`**: Usado para acessar membros da classe pai de dentro da classe filha.
  > - **`sealed`**: Impede que outras classes herdem de uma classe marcada como selada.

- 🎭 **Polimorfismo**: Permitindo que objetos de diferentes classes respondam à mesma mensagem de formas distintas (`virtual`, `override`).

    > Do grego "muitas formas". É a capacidade de um objeto ser tratado como um objeto de seu tipo base, mas se comportar de acordo com seu tipo específico. Permite que objetos de diferentes classes respondam à mesma mensagem (`método`) de maneiras únicas.
    >
    > **Como funciona?**
    > - **`virtual`**: Na classe base, um método é marcado como `virtual` para indicar que ele *pode* ser sobrescrito.
    > - **`override`**: Na classe derivada, o mesmo método é marcado com `override` para fornecer uma implementação específica.
    >
    > **Exemplo:** Um objeto `Carro` e um objeto `Bicicleta` podem ser tratados como um `Veiculo`. Ao chamar o método `Mover()` em cada um, o `Carro` vai "acelerar" e a `Bicicleta` vai "pedalar". A ação é a mesma, mas o comportamento é diferente.

- 👻 **Abstração**: Focar no "o que" um objeto faz, e não no "como" ele faz, escondendo detalhes de implementação com `abstract class` e `interfaces`.

  > Consiste em focar nos aspectos essenciais de um objeto, ignorando detalhes irrelevantes. Ela define um "contrato" do que um objeto deve fazer, sem especificar como ele deve fazer.
  >
  > **Como funciona?**
  > - **`abstract class`**: Uma classe que não pode ser instanciada e serve como um modelo base, podendo conter métodos com e sem implementação.
  > - **`interface`**: Um contrato puro que define apenas as assinaturas dos métodos, sem nenhuma implementação. Uma classe pode implementar múltiplas interfaces, garantindo que ela tenha certas capacidades.

---

## 🧰 Módulo 3: Ferramentas Essenciais e Contratos

Expandindo suas ferramentas para criar sistemas mais robustos, flexíveis e desacoplados.

- 🧬 **Genéricos (`Generics`)**: Criar componentes reutilizáveis e com segurança de tipo (`List<T>`).
- 📜 **Interfaces**: Definir "contratos" que as classes devem seguir, promovendo um baixo acoplamento.
- 📚 **Coleções**: Trabalhar com grupos de objetos de forma eficiente (`List<T>`, `Dictionary<TKey, TValue>`).
- 📡 **Delegates e Eventos**: Implementar o padrão *Observer* para comunicação entre objetos.
- 🛡️ **Tratamento de Exceções**: Escrever código resiliente que sabe lidar com erros (`try-catch-finally`).

---

## 🚀 Módulo 4: Tópicos Avançados e Recursos Modernos

Aprofundando o conhecimento sobre o funcionamento interno do .NET e utilizando recursos modernos do C#.

- 🧠 **Tipos de Valor vs. Tipos de Referência**: Entender a diferença crucial entre `struct` e `class` e como os dados são armazenados na memória.
- 🗑️ **Gerenciamento de Memória**: Uma visão sobre `Stack`, `Heap` e o papel do `Garbage Collector`.
- ✨ **Recursos Modernos do C#**: Explorar `Records`, `Tuplas`, `deconstrução de objetos` e outros recursos que facilitam o trabalho com dados.
- 💾 **Serialização e Atributos**: Como persistir o estado de um objeto e como adicionar metadados ao seu código.
