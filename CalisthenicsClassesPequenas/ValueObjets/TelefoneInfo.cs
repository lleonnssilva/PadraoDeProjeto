namespace CalisthenicsClassesPequenas.ValueObjets
{
    public class TelefoneInfo
    {
        private string _telefone { get; set; }
        public TelefoneInfo(string telefone)
        {
            this.Validate(telefone);
            this._telefone = telefone;
        }

        public string GetValue()
        {
            return this._telefone;
        }
        private void Validate(string telefone)
        {
            if (String.IsNullOrEmpty(telefone))
                throw new Exception("Telefone invalido");
        }
    }
}
