namespace CalisthenicsClassesPequenas.ValueObjets
{
    public class ContatoInfo
    {
        private TelefoneInfo _telefone { get; set; }
        private EmailInfo _email { get; set; }
        public ContatoInfo(TelefoneInfo phone, EmailInfo email)
        {
            this._telefone = phone;
            this._email = email;

        }

        public string GetEmail()
        {
            return this._email.GetValue();
        }
        public string GetTelefone()
        {
            return this._telefone.GetValue();
        }
    }
}

