# Polimorfismo

Vem do grego e significa "muitas formas". Permite sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

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
