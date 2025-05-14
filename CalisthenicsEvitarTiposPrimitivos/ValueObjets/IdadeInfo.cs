namespace CalisthenicsEvitarTiposPrimitivos.ValueObjets
{
    public class IdadeInfo
    {
        private int _idade { get;  set; }
        public IdadeInfo(int idade)
        {
            this.validate(idade);
            this._idade = idade;
        }
        public int GetValue()
        {
            return this._idade;
        }
        private void validate(int idade)
        {
            if (idade > 120)
                throw new Exception("Idade invalida");
        }
    }
}
