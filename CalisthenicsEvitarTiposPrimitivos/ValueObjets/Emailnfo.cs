namespace CalisthenicsEvitarTiposPrimitivos.ValueObjets
{
    public class Emailnfo
    {
        private string _email { get;  set; }
        public Emailnfo(string email)
        {
            this.Validate(email);
            this._email = email;
            
        }

        private void Validate(string email)
        {
            if (String.IsNullOrEmpty(email))
                throw new Exception("Email invalido");
        }
        public string GetValue()
        {
            return this._email;
        }
    }
}
