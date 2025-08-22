# Tipos Primitivos

O conceito de "tipos primitivos" é a base de qualquer linguagem de programação.

Em C#, tipos primitivos são os tipos de dados mais fundamentais, diretamente suportados pelo compilador. Pense neles como os "átomos" ou os "blocos de construção" a partir dos quais todos os outros tipos mais complexos são criados.

A principal característica deles é que são, em sua maioria, Tipos de Valor (Value Types), o que significa que armazenam seu valor diretamente na memória (na Stack) e são muito eficientes.

Em C#, os tipos primitivos são, na verdade, "apelidos" (aliases) para structs que já existem no .NET. Por exemplo, quando você escreve `int`, o compilador entende como `System.Int32`.

Aqui estão os principais tipos primitivos, agrupados por categoria:

## Tipos Numéricos Integrais (Números Inteiros)

| Palavra-chave | Tipo .NET | Descrição |
|:---|:---|:---|
| int | System.Int32 | O mais comum para números inteiros.|
| long | System.Int64 | Para números inteiros muito grandes.|
| short | System.Int16 | Para números inteiros pequenos.|
| byte | System.Byte | Para números pequenos, de 0 a 255.|

## Tipos Numéricos de Ponto Flutuante (Números com Decimais)

| Palavra-chave | Tipo .NET | Descrição |
|:---|:---|:---|
| double | System.Double | O padrão para números com decimais, boa precisão.|
| float | System.Single | Menor precisão que double.|
| decimal | System.Decimal | Altíssima precisão, ideal para cálculos financeiros.|

## Tipo Booleano

| Palavra-chave | Tipo .NET | Descrição |
|:---|:---|:---|
| bool |System.Boolean | Armazena apenas true ou false.|

## Tipo Caractere

| Palavra-chave | Tipo .NET | Descrição |
|:---|:---|:---|
| char | System.Char | Armazena um único caractere (letra, número, símbolo).|

## O Caso Especial: `string`

O tipo `string` (`System.String`) é frequentemente discutido junto com os primitivos porque possui uma sintaxe literal ("meu texto") e é usado constantemente. No entanto, é importante saber que ele é um **Tipo de Referência (Reference Type)**, não um Tipo de Valor.
