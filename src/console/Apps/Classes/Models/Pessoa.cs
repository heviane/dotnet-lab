namespace Models
{
    public class Pessoa
    {

        // Construtores (Propriedades recebem variáveis)
        public Pessoa(int id, string name, string lastName, DateTime birthday)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Birthday = birthday;
        }

        public Pessoa()
        {
            int id = 0; string name = string.Empty; string lastName = string.Empty; DateTime birthday = DateTime.MinValue;
        }

        // Desconstrutores (Variáveis recebem propriedades)
        public void Deconstruct(out int id, out string name, out string lastName, out DateTime birthday)
        {
            id = Id;
            name = Name;
            lastName = LastName;
            birthday = Birthday;
        }

        private string _name = string.Empty;

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public int Age { get { return (int)((DateTime.Now - Birthday).TotalDays / 365.25); } }
        public bool IsAdult => Age >= 18;
        public string FullName => $"{Name} {LastName}";

        public virtual void Apresentar()
        {
            Console.WriteLine($"Id {Id}: - Olá, meu nome é {FullName}, tenho {Age} anos, pois nasci em {Birthday.ToString("dd/MM/yyyy")}. Sou maior de idade? {IsAdult}.");
        }
    }
}
