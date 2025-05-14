using CalisthenicsClassesPequenas.ValueObjets;


namespace CalisthenicsClassesPequenas
{
    public class Cliente
    {
        private readonly ContatoInfo _contato;
        private readonly EnderecoInfo _endereco;
        private string _nome;
        public Cliente(string nome,ContatoInfo contato, EnderecoInfo endereco)
        {
            
            this.Validate(nome);
            this._nome = nome;
            this._contato = contato;
            this._endereco = endereco;
        }
        private void Validate(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome invalido");
        }
        public string GetNome()
        {
            return this._nome;
        }
        public string GetEmail()
        {
            return this._contato.GetEmail();
        }
        public string GetTelefone()
        {
            return this._contato.GetTelefone();
        }
        public string GetEnderecoFormatado()
        {
            var endereco = String.Format("Logradouro:{0}\nBairro: {1}\nNúmero: {2}\nCidade: {3}\nMunicipio: {4}\nEstado: {5}",
                this._endereco.GetRua(),
                this._endereco.GetBairro(),
                this._endereco.GetNumero(),
                this._endereco.GetCidade(),
                this._endereco.GetMunicipio(),
                this._endereco.GetEstado());
            return endereco;
        }

    }
}
