using Classes.Interfaces;

namespace Classes
{
    public class CalculadoraComum : ICalculadora
    {
        // Classe "CalculadoraComum" implementa a interface "ICalculadora"
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
