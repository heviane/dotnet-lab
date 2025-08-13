public static class LoopsApp
{
    public static void RunProject1()
    {
        /*
            O código a seguir é uma solução possível para o projeto 1 do desafio da unidade anterior.
            O código usa uma instrução do porque o bloco de código deve ser executado pelo menos uma vez.
            Também É POSSÍVEL usar um while para obter o mesmo resultado. Alguns desenvolvedores consideram que a lógica de um while torna o código mais legível.
            Nesse caso, é possível optar pela implementação de uma instrução while aqui.
        */

        string? readResult;
        string valueEntered = "";
        int numValue = 0;
        bool validNumber = false;

        Console.WriteLine("--- Project 1: Enter an integer value between 5 and 10 ---");

        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                valueEntered = readResult;
            }

            validNumber = int.TryParse(valueEntered, out numValue);

            if (validNumber == true)
            {
                if (numValue <= 5 || numValue >= 10)
                {
                    validNumber = false;
                    Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
        } while (validNumber == false);

        Console.WriteLine($"Your input value ({numValue}) has been accepted.");
        Console.WriteLine("-------------------------------------------------------\n");
    }

    public static void RunProject2()
    {
        string? readResult;
        string roleName = "";
        bool validEntry = false;

        Console.WriteLine("--- Project 2: Enter your role name (Administrator, Manager, or User) ---");

        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                roleName = readResult.Trim();
            }

            if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
            {
                validEntry = true;
            }
            else
            {
                Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
            }

        } while (validEntry == false);

        Console.WriteLine($"Your input value ({roleName}) has been accepted.");
        Console.WriteLine("--------------------------------------------------------------------------\n");
    }

    public static void RunProject3()
    {
        Console.WriteLine("--- Project 3: Extract sentences from strings ---");
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (string myString in myStrings)
        {
            string currentString = myString;
            int periodLocation = currentString.IndexOf(".");

            while (periodLocation != -1)
            {
                Console.WriteLine(currentString.Remove(periodLocation).Trim());
                currentString = currentString.Substring(periodLocation + 1).TrimStart();
                periodLocation = currentString.IndexOf(".");
            }
            Console.WriteLine(currentString.Trim());
        }
        Console.WriteLine("-------------------------------------------------\n");
    }
}
