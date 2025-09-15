namespace Models
{
    // Student herda da Pessoa usando a sintaxe ': Pessoa'. Student "é um" Pessoa e herda todas as suas propriedades e métodos públicos.
    public sealed class Student : Pessoa
    {
        public Student(string name) : base(name)
        {
            // método construtor da classe pai Pessoa
            // base(name) chama o construtor da classe base (Pessoa) e passa o parâmetro 'name' para ele.
        }
        public string StudentID { get; set; } = string.Empty;

        // Exemplo de Polimorfismo: Sobrescrevendo (override) o método Apresentar para adicionar informações específicas do aluno.
        public override void Apresentar()
        {
            // Chama a implementação original do método Apresentar da classe base (Pessoa). Isso evita a repetição de código.
            base.Apresentar();
            // Adiciona a informação extra, específica do aluno.
            Console.WriteLine($"  > Meu ID de estudante é: {StudentID}");
        }
    }
}
