# Classe Abstrata

Tem como objetivo *ser exclusivamente um modelo* para ser herdado, portanto *não pode ser instanciada*.

Podemos implementar métodos ou deixá-los a cargo de quem herdar.

Exemplo de classe abstrata: `public abstract class Conta`.
Exemplo de método abstrato: `public abstract void Creditar(decimal valor);`, este método não tem implementação/corpo.
A classe que herda é obrigada a implementar este método, e deve usar a palavra reservada `override`.

No exemplo, foi criado a propriedade `saldo` usando o modificador `protected`, isso significa que as classes que herdam tem acesso.
