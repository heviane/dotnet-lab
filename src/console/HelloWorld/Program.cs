// See https://aka.ms/new-console-template for more information

/*
    Um projeto C# só pode ter um único ponto de entrada.

    Quando você escreve código diretamente em um arquivo .cs sem envolvê-lo em uma classe com um método Main,
    o compilador do C# assume que aquele arquivo é o ponto de entrada do programa.

    Código solto é o que chamamos de "instruções de nível superior" ou top-level statements.
*/


// -------------------- Challenge - if-else-elseif
Random random = new Random();
int daysUntilExpiration = random.Next(20);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine($"Your subscription is valid for {daysUntilExpiration} more days.");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

// -------------------- Challenge - if-else-elseif
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// -------------------- Challenge - Arrays
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";  // Error: Index was outside the bounds of the array
*/

// Initializing an array with a collection initializer
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000"; // Reassigning the first element

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// -------------------- Challenge - Arrays + foreach
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

// -------------------- Challenge - Arrays + foreach
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

// -------------------- Challenge - Arrays + foreach
/*
   This code reverses a message, counts the number of times
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

// -------------------- Challenge - Operadores
// Operador de igualdade (==)
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Operador de desigualdade (!=)
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

// Operadores de comparação (>, <, >=, <=)
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// Negação lógica (!)

// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

// Operador de desigualdade versus negação lógica
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

// -------------------- Challenge - Operador ternário
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// -------------------- Challenge - blocos de código e escopo de variaveis
// EX 1
/*
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
// Console.WriteLine($"Outside the code block: {value}"); // *** ERROR ***
*/

// EX 2
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

//-------------------- Challenge - Blocos de código e escopo de variáveis
// Before
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;
    total += number;
    if (number == 42)
    {
        bool found = true;
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");
*/

// After
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

/*
    As maiores alterações no código problemático incluíram:
    Movendo a declaração das variáveis total e found para fora da instrução foreach.
    Inicializando ambas as variáveis total e found com valores padrão sensatos.
    Remover os blocos de código (chaves) das instruções if.
*/

// -------------------- Challenge
// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>

/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

// -------------------- Challenge - refatorar o código acima usando switch case
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");



// -------------------- Challenge - Conversão de tipos
// Conversão implícita (implicit conversion)
int number1 = 12345;
long bigNumber = number1; // int para long (int é menor que long)
Console.WriteLine(bigNumber);

// Conversão explícita (explicit conversion)
double price = 99.99;
int priceAsInt = (int)price; // double para int (double é maior que int)
Console.WriteLine(priceAsInt);

int number2 = Convert.ToInt32("42");
Console.WriteLine(number2);

int number3 = int.TryParse("43", out int result) ? result : 0;
Console.WriteLine(number3);

int number4 = int.Parse("44");
Console.WriteLine(number4);

/*
    Diferença entre Convert.ToInt32 e int.TryParse e int.Parse:
    - Tratamento de valores nulos.
        - SE Convert.ToInt32 e int.TryParse recebem um valor nulo, ele converte para 0.
        - SE int.Parse recebe um valor nulo, ele lança um erro de compilação.

    É mais recomendado usar a classe Convert ou o método TryParse().
*/

int number5 = 5;
string numberString = number5.ToString();
Console.WriteLine(numberString);

// -------------------- Challenge - Valores máximos dos tipos numéricos
Console.WriteLine("int: " + int.MaxValue);
Console.WriteLine("long: " + long.MaxValue);
Console.WriteLine("float: " + float.MaxValue);
Console.WriteLine("double: " + double.MaxValue);
Console.WriteLine("decimal: " + decimal.MaxValue);

// -------------------- Challenge - switch case com entrada de dados pelo usuário
Console.WriteLine("Enter a number between 1 and 5:");
string input = Console.ReadLine();
int number = int.TryParse(input, out int parsedNumber) ? parsedNumber : 0;

switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 4:
        Console.WriteLine("Four");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    default:
        Console.WriteLine("Invalid number   (1-5).");
        break;
}
