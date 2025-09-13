# Descartes em Tuplas

Ao usar tuplas, pode acontecer de as vezes não usarmos todos os valores, e portanto podemos descartar os valores não usados para tornar o código mais eficiente e legivel.

Para descartar valores retornados pela Tupla e não utilizados, use o **underline ( _ )** no lugar do valor.

Exemplo:

```csharp
(string nome, int idade, string cidade) GetPessoa()
{
    return ("João", 30, "São Paulo");
}
var (nome, _, cidade) = GetPessoa();
Console.WriteLine($"Nome: {nome}, Cidade: {cidade}");
```
