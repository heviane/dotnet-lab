namespace Models
{
    public class Pessoa
    {

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

        private string _name = string.Empty;
        private int _age;

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public int Age { get { return (int)((DateTime.Now - Birthday).TotalDays / 365.25); } }
        public bool IsAdult => Age >= 18;
        public string FullName => $"{Name} {LastName}";

        public virtual void Apresentar()
        {
            Console.WriteLine($"- Olá, meu nome é {FullName}, tenho {Age} anos, pois nasci em {Birthday.ToString("dd/MM/yyyy")}. Sou maior de idade? {IsAdult}.");
        }
    }
}
