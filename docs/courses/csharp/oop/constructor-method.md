# Método Construtor

Usar um método construtor é muito mais forte do que um onde as propriedades poderiam ser definidas depois, pois ele resolve um problema real de design: como garantir que um objeto sempre nasça em um estado consistente e funcional.

Um construtor faz sentido quando um objeto não pode existir ou não tem utilidade em um estado inválido ou incompleto.
O construtor é o local perfeito para validar os dados de entrada e garantir a integridade do objeto.

O construtor tem como finalidade atribuir valores para um objeto no momento de sua criação

## Pontos Chaves

- Toda classe tem um construtor por padrão
- Pode haver N construtores (Não existe limite máxcimo)

## Vantagens

- **Garantia de Estado Válido**: O principal benefício. Você, como criador da classe, garante que qualquer objeto ContaBancaria criado será sempre válido, pois o compilador obriga o fornecimento dos dados essenciais.
- **Obrigatoriedade e Clareza**: Quem for usar sua classe saberá imediatamente, só de olhar para o construtor, quais informações são indispensáveis para criar um objeto.
- **Validação Centralizada**: O construtor é o lugar ideal para colocar validações (Guard Clauses). Se os dados fornecidos forem inválidos (ex: um número de conta vazio), você pode lançar uma exceção imediatamente, evitando problemas futuros.
- **Imutabilidade de Dados Essenciais**: Note que usei init nos setters das propriedades NumeroConta e NomeTitular. Isso significa que, uma vez definidas no construtor, elas não podem mais ser alteradas. Isso é perfeito para dados que devem ser permanentes, como o número de uma conta.

## Exemplos

- [Conta Bancária](../../../../src/console/Apps/Classes/Models/ContaBancaria.cs): Um exemplo prático de como usar construtores para garantir que uma conta bancária sempre tenha um número de conta e um titular válidos.
