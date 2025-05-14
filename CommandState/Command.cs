namespace CommandState
{
    public class Command : ICommand
    {
        public Command(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get;private set; }
        public string Nome { get; private set; }
        public void Execute()
        {
            Console.WriteLine($"Comando executado: {this.Id} - {this.Nome}");
        }
    }
}
