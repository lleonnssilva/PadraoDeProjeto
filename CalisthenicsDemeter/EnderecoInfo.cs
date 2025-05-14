namespace CalisthenicsDemeter.ValueObjets
{
    public class EnderecoInfo
    {
        private string _rua { get; set; }
        private string _bairro { get; set; }
        private string _cidade { get; set; }
        private string _numero { get; set; }
        private string _municipio { get; set; }
        private string _estado { get; set; }
        private string _cep { get; set; }
        public EnderecoInfo(string rua, string bairro, string cidade, string numero, string municipio, string estado, string cep)
        {

            this._rua = rua;
            this._bairro = bairro;
            this._cidade = cidade;
            this._numero = numero;
            this._municipio = municipio;
            this._estado = estado;
            this._cep = cep;
        }
        public string GetRua()
        {
            return this._rua;
        }
        public string GetBairro()
        {
            return this._bairro;
        }
        public string GetCidade()
        {
            return this._cidade;
        }
        public string GetNumero()
        {
            return this._numero;
        }
        public string GetMunicipio()
        {
            return this._municipio;
        }
        public string GetEstado()
        {
            return this._estado;
        }
        public string GetCep()
        {
            return this._cep;
        }
    }
}
