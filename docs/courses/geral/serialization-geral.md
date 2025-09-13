# Serialização

A serialização é um conceito geral e fundamental da ciência da computação e da programação, não algo exclusivo do C# ou da plataforma .NET.

O processo de **serializar** dados consiste em transformar objetos em fluxo de bytes para seu armazenamento ou transmissão.
O resultado final será de acordo com o destino de armazenamento, por exemplo: database, memória ou arquivos.

O processo de **deserialização** é o inverso, transformar dados de algum tipo/formato em objetos.

## Pense da seguinte forma

**O Problema (Geral)**: Qualquer aplicação, em qualquer linguagem, eventualmente enfrenta a necessidade de "salvar" o estado de um dado ou enviá-lo para outro lugar (seja para um arquivo, um banco de dados ou pela rede). O desafio é: como transformar uma estrutura de dados complexa que vive na memória em um formato linear (como uma string ou uma sequência de bytes) que possa ser armazenado ou transmitido?

**A Solução (Conceito Geral)**: A solução para esse problema é a serialização. É o nome que se dá a esse processo de conversão. Linguagens como Java, Python, JavaScript, Go, Ruby, etc., todas possuem seus próprios mecanismos e bibliotecas para realizar a serialização.

**A Implementação (Específica do .NET e C#)**: A plataforma .NET implementa o conceito de serialização, oferecendo um conjunto de ferramentas e bibliotecas poderosas para isso. O C#, como principal linguagem do .NET, é a linguagem que você usa para interagir com essas ferramentas.

| Nível | Descrição | Exemplo |
|-------|-----------|---------|
| Conceito Geral (Programação)| A ideia de converter um objeto em um formato para armazenamento/transmissão. | Serialização |
| Implementação (Plataforma .NET) | Bibliotecas e ferramentas que realizam a serialização. | System.Text.Json, System.Xml.Serialization |
| Uso (Linguagem C#) | A sintaxe e o código que você escreve para usar essas bibliotecas. | string json = JsonSerializer.Serialize(meuObjeto); |

## Analogia

Pense no conceito de "loop" (iteração).

**Conceito Geral**: Repetir um bloco de código várias vezes.
**Implementação em C#**: As palavras-chave for, while, foreach.

Da mesma forma:

**Conceito Geral**: Converter um objeto para um formato transmissível.
**Implementação em C#/.NET**: As classes JsonSerializer, XmlSerializer, etc.

Portanto, o conhecimento sobre "o que é" e "por que" a serialização é importante é universal e transferível para outras tecnologias. A forma como você a executa (o código específico) é o que muda de uma plataforma para outra.

## References

- [Serialização no C#](../csharp/serialization-csharp.md)
