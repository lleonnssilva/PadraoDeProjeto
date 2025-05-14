using CalisthenicsEvitarTiposPrimitivos.ValueObjets;

namespace CalisthenicsEvitarTiposPrimitivos
{
    public class Cliente
    {
        private Emailnfo _email { get; set; }
        private CpfInfo _cpf { get;  set; }
        private IdadeInfo _idade { get;  set; }
        private string _nome { get;  set; }
        public Cliente(string nome,Emailnfo email, CpfInfo cpf, IdadeInfo idade)
        {
            this.validate(nome);
            this._nome = nome;
            this._email = email;
            this._cpf = cpf;
            this._idade = idade;
        }
        public string GetNome()
        {
            return this._nome;
        }
        private void validate(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome invalido");
        }

        public string GetEmail()
        {
            return this._email.GetValue();
        }
        public string GetCpf()
        {
            return this._cpf.GetValue();
        }
        public int GetIdade()
        {
            return this._idade.GetValue();
        }
    }
}
