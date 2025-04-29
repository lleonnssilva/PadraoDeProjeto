namespace DecoratorJurosProduto
{
    public class Produto
    {
        public Produto(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get;private set; }
        public double Valor { get; private set; }
    }
}