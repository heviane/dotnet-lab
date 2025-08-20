// Challenge 1 - This code generates a random number between 1 and 6, simulating a dice roll
namespace Models;

using System;

public class DiceGame
{
    // Este método não precisa de 'static' porque vamos criar um objeto (instância) da classe para usá-lo.
    public void Play()
    {
        Console.WriteLine($"\n--- Dice Games: ---");
        /*
            Nesta primeira parte, é criado uma instancia da classe Random, que chama o método Next() a partir do objeto dice gerado.
        */
        Random dice = new Random();

        int roll1 = dice.Next(1, 7); // Generate a random number between 1 and 6 (inclusive)
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        /*
            Nesta segunda parte, é incluido uma referência à classe Console, que chama o método Console.WriteLine() diretamente.
        */
        Console.WriteLine($"- (Generate three random numbers between 1 and 6) - Rolls: roll1={roll1}, roll2={roll2}, roll3={roll3}");

        /*
            A razão, é porque alguns métodos são "com estado" (com instanciação de objetos) e outros são "sem estado" (com referência direta).
        */

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"- Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }

            Console.WriteLine($"Your total including the bonus: {total}");
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
    }
}
