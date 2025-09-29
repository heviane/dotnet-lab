using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Interfaces
{
    // Por convenção, os nomes das interfaces sempre iniciam com a letra "I"
    public interface ICalculadora
    {
        // Aqui não precisamos usar modificadores de acesso, pois fica subentendido que serão publicos
        int Sum(int number1, int number2);
        int Subtract(int number1, int number2);
        int Multiple(int number1, int number2);
        // A implementação deste método não será obrigatório, porque algo já foi implementado aqui
        // Tornou-se OPCIONAL *** Métodos sem corpo são OBRIGATÓRIOS ***
        int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        // TODO: Implementar as classes CalculadoraComum e CalculadoraCientifica que devem implementar esta interface.
        // As classes devem importar a interface
        // No visual há um atalho para criar automaticamente as implementações da interface
        // public class CalculadoraComum : ICalculadora
        // Seleciona a interface + CTRL
    }
}
