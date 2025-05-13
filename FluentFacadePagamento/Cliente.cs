namespace FluentFacadePagamento
{
    public class Cliente
    {
        public static Cliente Build()
        {
            return new Cliente();
        }

        public string Nome { get; private set; } = "";
        public Cliente DefinirNome(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public string Telefone { get; private set; } = "";
        public Cliente DefinirTelefone(string telefone)
        {
            this.Telefone = telefone;
            return this;
        }

        public string Email { get; private set; } = "";
        public Cliente DefinirEmail(string emil)
        {
            this.Email = emil;
            return this;
        }

        public string Cpf { get; private set; } = "";
        public Cliente DefinirCpf(string cpf)
        {
            this.Cpf = cpf;
            return this;
        }

        public int Idade { get; private set; } = 0;
        public Cliente DefinirIdade(int idade)
        {
            this.Idade = idade;
            return this;
        }
    }
}
