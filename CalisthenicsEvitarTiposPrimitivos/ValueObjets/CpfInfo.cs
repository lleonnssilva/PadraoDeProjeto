namespace CalisthenicsEvitarTiposPrimitivos.ValueObjets
{
    public class CpfInfo
    {
        private string _cpf { get; set; }
        public CpfInfo(string cpf)
        {
            this.Validate(cpf);
            this._cpf = cpf;
            
        }
        public string GetValue()
        {
            return this._cpf;
        }
        private void Validate(string cpf)
        {
            if (String.IsNullOrEmpty(cpf))
                throw new Exception("Cpf invalido");
        }
    }
}
