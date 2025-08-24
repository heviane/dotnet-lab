# Struct

É, em sua essência, um conceito da linguagem C# para a criação de Tipos de Valor (Value Types).

Embora a ideia de uma "estrutura" para agrupar dados seja um conceito de programação geral (presente em linguagens mais antigas como o C, que não é orientada a objetos), a forma como o struct funciona em C# está intimamente ligada ao seu sistema de tipos e gerenciamento de memória.

Diferente de `interface` (que é um pilar da Abstração em POO), a principal razão de existir de um `struct` em C# é performance e semântica de valor:

- **Tipo de Valor**: Uma struct é um tipo de valor, o que significa que é geralmente armazenada na Stack (memória rápida) e copiada quando atribuída a outra variável.
- **Uso Principal**: É ideal para pequenas estruturas de dados onde o valor em si é mais importante que a identidade do objeto (ex: um ponto 2D, uma cor RGB).
- **Limitações de POO**: Structs não suportam herança, um dos pilares fundamentais da POO. Elas podem implementar interfaces, o que lhes permite participar de um design orientado a objetos, mas não são o principal veículo para isso.

## RESUMO

Enquanto uma `class` é a ferramenta principal para modelar o comportamento e a identidade de objetos no paradigma POO, uma `struct` é uma ferramenta da linguagem C# para criar tipos de dados leves e eficientes, com semântica de valor.
