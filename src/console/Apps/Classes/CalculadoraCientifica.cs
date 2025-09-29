using Classes.Interfaces;

namespace Classes
{
    // Classe "CalculadoraCientifica" implementa a interface "ICalculadora"
    public class CalculadoraCientifica : ICalculadora
    {
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
