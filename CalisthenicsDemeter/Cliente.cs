


using CalisthenicsDemeter.ValueObjets;

namespace CalisthenicsDemeter
{
    public class Cliente
    {

        private readonly EnderecoInfo _endereco;
        private string _nome;
        public Cliente(string nome, EnderecoInfo endereco)
        {
            
            this.Validate(nome);
            this._nome = nome;
            this._endereco = endereco;
        }
        private void Validate(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome invalido");
        }
        public string GetValue()
        {
            return this._nome;
        }
        public string GetEnderecoFormatado()
        {
            var endereco = String.Format("Logradouro:{0}\nBairro: {1}\nNúmero: {2}\nCidade: {3}\nMunicipio: {4}\nEstado: {5}\nCep: {6}",
                this._endereco.GetRua(),
                this._endereco.GetBairro(),
                this._endereco.GetNumero(),
                this._endereco.GetCidade(),
                this._endereco.GetMunicipio(),
                this._endereco.GetEstado(),
                this._endereco.GetCep());
            return endereco;
        }
        public string GetCep()
        {
            return this._endereco.GetCep();
        }

    }
}
