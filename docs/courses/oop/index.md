# POO (Programação Orientada a Objetos)

É um paradigma de programação, ou seja, uma técnica de programação para um fim especifico.

O principal conceito são **classes** e **objetos**.

- **classe**: Representação abstrato de algo do mundo real, representação de um objeto. Uma classe possui caracteristicas/propriedades e comportamentos/métodos.
- **objeto**: É a classe concretizada, é uma implementação da classe.

Dentro desta técnica, existem quatro pilares:

- **Abstração**: Abstrair um objeto do mundo real para um *contexto especifico*, considerando apenas os *atributos importantes*. Trabalhar sempre na simplicidade.
- **Encapsulamento**: Serve para proteger uma classe e definir limites para alteração de suas propriedades. Serve para ocultar seu comportamento e expor somente o necessário.
- **Herança**: Nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes. Serve para agrupar objetos que são do *mesmo tipo*, porém com *caracteristicas diferentes*. Classe pai e classe filha. CUIDADO com a complexidade de uma classe com mais de uma herança (herança em cascata), pois isso gera muita dependência, o que não é desejavel em programação, pois pode quebrar a aplicação. O conceito de **herança multipla** (uma classe herdar de duas outras classes ao mesmo tempo) não existe no C#.

  - Definir um método construtor padrão na classe pai para ser usado nas classes filhas.

- **Polimorfismo**: Vem do grego e significa "muitas formas". Permite sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.
  - Na classe pai é necessário configurar que determinado método pode ser feito polimorfismo (sobrescrito), por exemplo: `public virtual void Apresentar()`, usando a palavra reservada `virtual`no método.
  - Na classe filha use a palavra reservada `override` para sobrescrever, por exemplo: `public override void Apresentar()`, caso não queira sobrescrever, basta usar dentro do método `base.Apresentar()`.

> **virtual** significa que o método pode ser sobrescrito se a classe filha assim desejar!
> **override** significa que o método está sendo sobrescrito!

Objetivo do polimorfismo: Sobrescrever os métodos de sua classe derivada, permitindo classes especializadas.

Há dois tipos de polimorfismo, um que depende de herança e um que não depende de herança:

- Polimorfismo em tempo de compilação que NÃO depende de herança: Overload/Early Binding
Método com nome e tipo de retorno iguais, mas quantidade de argumentos diferentes.
- Polimorfismo em tempo de execução que SIM depende de herança: Override/Late Binding
Sobrescrita de métodos com os usos das palavras reservadas `virtual` e `override`.
