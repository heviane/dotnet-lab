# Delegate

É um tipo que representa referências a métodos com uma assinatura.
É um tipo especial que funciona como um "ponteiro" seguro para um método.

Pense nele como uma variável que, em vez de guardar um número ou um texto, guarda uma referência para um método. Isso permite que você trate métodos como se fossem dados: passando-os como argumentos para outras funções, armazenando-os em variáveis e invocando-os dinamicamente.

É a base para o sistema de eventos do C# (como cliques de botão) e para o funcionamento do `LINQ`.

## Exemplo Prático

```csharp
// 1. Define o "contrato" do delegate: qualquer método que não retorne nada (void)
//    e receba uma string como parâmetro.
public delegate void MeuDelegateDeMensagem(string mensagem);

// 2. Cria um método que corresponde à assinatura do delegate.
public void ExibirMensagemNoConsole(string msg)
{
    Console.WriteLine(msg);
}

// 3. Usa o delegate para "apontar" para o método.
MeuDelegateDeMensagem manipulador = ExibirMensagemNoConsole;

// 4. Invoca o método através do delegate.
manipulador("Olá, Delegate!"); // Saída: Olá, Delegate!
```

## Conceitualmente

Delegate é um conceito específico do C# (e da plataforma .NET).

Embora não seja um dos quatro pilares fundamentais da Programação Orientada a Objetos (Encapsulamento, Herança, Polimorfismo e Abstração), os delegates são ferramentas poderosas que são amplamente utilizadas em contextos de POO para implementar **padrões de design** e funcionalidades orientadas a objetos, como:

- Eventos: São a base do sistema de eventos em C#, permitindo que objetos notifiquem outros objetos sobre ocorrências (como um clique de botão).
- Callbacks: Permitem que um método passe outro método como argumento, para ser executado posteriormente.
- Padrões de Design: Facilitam a implementação de padrões como o Observer, Strategy e Command.
- LINQ: O Language Integrated Query utiliza delegates internamente para suas operações de consulta.

## RESUMO

Delegate é um tipo de dado em C# (um tipo de referência) que permite tratar métodos como objetos. Sua utilidade e aplicação se estendem profundamente ao paradigma da Programação Orientada a Objetos, tornando-o uma ferramenta essencial para o desenvolvimento em C#.
