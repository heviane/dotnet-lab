namespace Models;

public static class Employee
{
    // Criamos um método 'static' para não precisar criar uma instância da classe.
    // Ele recebe um 'level' como entrada e retorna o 'title' como uma string.
    public static string GetTitle(int employeeLevel)
    {
        string title = "";
        switch (employeeLevel)
        {
            // os rótulos case 40: e case 50: executam a mesma seção de comutador.
            case 40:
            case 50:
                title = "Intern";
                break;

            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }
        return title;
    }
}
