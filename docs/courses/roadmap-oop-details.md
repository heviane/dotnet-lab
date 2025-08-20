# Roadmap: Programação Orientada a Objetos (POO)

A Programação Orientada a Objetos é um paradigma fundamental no desenvolvimento de software moderno e uma habilidade essencial para qualquer desenvolvedor .NET.

---

## Módulo 1: A Base da POO

O ponto de partida. Aqui, você entenderá o que são objetos e como eles são construídos.

- Conceitos Iniciais:
  - Abstração

- Classes and Objects: O que é um "molde" (Classe) e o que é uma "instância" (Objeto). A base de tudo.
  - Composição: Onde uma classe (Course) é composta por uma coleção de outras classes (Pessoa).

- **Propriedades, Métodos e Construtores**: Os blocos de construção de uma classe. Como um objeto armazena dados (Propriedades), executa ações (Métodos) e é inicializado (Construtores).
  - Propriedades
    - Métodos getters e setters
      - propriedades automáticas
      - propriedades com lógica adicional - Campos de apoio ("backing fields")
      - Body Expressions
      - Somente leitura (only getters)
      - Somente escrita (only setters)
      - Validações na declaração de propriedades

  - Métodos
    - Métodos Construtores (inicializadores de objeto)
    - Métodos com estado (instanciação de objetos)
    - Métodos sem estado (referenciados diretamente, sem instanciação de objetos) - Métodos estáticos
      - **Membros Estáticos (`static`)**: Entendendo a diferença entre membros que pertencem a uma instância e membros que pertencem à própria classe.
    - Assinaturas de métodos: É um conceito fundamental e a base para entender a "sobrecarga de métodos" (method overloading).
      - De forma simples, a assinatura de um método é a sua "identidade" única para o compilador.
        - Ela é composta por três elementos principais:
          - O nome do método.
          - O número de parâmetros.
          - O tipo e a ordem de cada parâmetro.
        - O que NÃO faz parte da assinatura?
          - O tipo de retorno: Você não pode ter dois métodos que diferem apenas no que eles retornam.
          - Os nomes dos parâmetros: Apenas os tipos e a ordem importam, não os nomes que você dá a eles.
          - Os modificadores de acesso (public, private, etc.).
          - A palavra-chave static.
    - Sobrecarga de métodos (method overloading): Permite que uma classe ofereça várias maneiras de chamar um método com o mesmo nome, tornando mais flexível e intuitiva para quem a utiliza.
      - O conceito de sobrecarga de método (method overloading) exige que os métodos tenham o mesmo nome, mas assinaturas diferentes.
      - Ex.: `Console.WriteLine()`
    - Polimorfismo: Sobrescrevendo (override) na classe, exemplo em [Student que herda de Pessoa](../../src/console/Apps/Classes/Models/Student.cs)

- Propriedades e Métodos
  - Modificadores de Acesso (`public`, `private`, `protected`). Conceito de **Encapsulamento**.
    - public: Acessível a todos.
    - private: Acessível apenas dentro da classe.
      - Ex.: Quando precisamos validar um valor antes de armazená-lo, de fato. Por exemplo, propriedades com lógica adicional (getters e setters).
      - Neste caso, os campos de apoio são private, e os atributos da classe são public.
    - protected: Acessível dentro da classe e nas subclasses.

---

## Módulo 2: Os 4 Pilares da POO

Estes são os princípios que dão poder e flexibilidade à POO.

- **Encapsulamento**: Protegendo e organizando seu código com modificadores de acesso (`public`, `private`).
- **Herança**: Reutilizando código e criando hierarquias de classes (`base`, `derived`).
- **Polimorfismo**: Permitindo que objetos de diferentes classes respondam à mesma mensagem de formas distintas (`virtual`, `override`).
- **Abstração**: Focando no essencial e escondendo a complexidade com `abstract class`.

---

## Módulo 3: Contratos e Coleções

Expandindo suas ferramentas para criar sistemas mais robustos e flexíveis.

- **Interfaces**: Definindo "contratos" que as classes devem seguir, promovendo um baixo acoplamento.
- **Coleções**: Trabalhando com grupos de objetos de forma eficiente usando `List<T>`, `Dictionary<TKey, TValue>`, etc.
- **Tratamento de Exceções**: Escrevendo código resiliente que sabe como lidar com erros e situações inesperadas (`try-catch-finally`).

---

## Módulo 4: Tópicos Avançados e Conceitos do .NET

Aprofundando o conhecimento sobre como o .NET gerencia seus objetos.

- **Tipos de Valor vs. Tipos de Referência (`struct` vs `class`)**: Entendendo as diferenças fundamentais de como os dados são armazenados.
- **Stack, Heap e Garbage Collector**: Uma visão sobre o gerenciamento de memória no .NET.
- **Serialização e Atributos**: Como persistir o estado de um objeto e como adicionar metadados ao seu código.
- **Recursos Adicionais da Linguagem**: Explorando `Tuplas`, `Records`, `deconstrução de objetos` e outros recursos modernos do C# que facilitam o trabalho com dados.

## PLANNING / SCHEDULE / MONITORING

- [https://dio.me](https://dio.me) - DIO - Digital Innovation One
  - OOP
    - [X] DIO modulo 1: Propriedades, Métodos e Construtores.
      - **commit**: `feat(poo): Adiciona exemplos de Propriedades, Métodos e Construtores (módulo 1)`
    - [ ] DIO modulo 2: Manipulando valores e passar parametros por referencia.
    - [ ] DIO modulo 3: Exceções e Coleções.
