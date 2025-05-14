namespace CalisthenicsClassesPequenas.ValueObjets
{
    public class EmailInfo
    {

        private string _email { get;  set; }
        public EmailInfo(string email)
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
