while (true)
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("      Desafios de Loops       ");
    Console.WriteLine("===================================");
    Console.WriteLine("Escolha um projeto para executar:");
    Console.WriteLine("1. Projeto 1 - Validar entrada entre 5 e 10");
    Console.WriteLine("2. Projeto 2 - Validar entrada de Role (Admin, Manager, User)");
    Console.WriteLine("3. Projeto 3 - Extrair sentenças de strings");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("0. Sair");
    Console.WriteLine("===================================");
    Console.Write("Digite sua opção: ");

    string? choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            LoopsApp.RunProject1();
            break;
        case "2":
            LoopsApp.RunProject2();
            break;
        case "3":
            LoopsApp.RunProject3();
            break;
        case "0":
            Console.WriteLine("Saindo do projeto de Loops...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine("\n...Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}
