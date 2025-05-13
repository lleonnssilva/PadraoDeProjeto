namespace DecoratorJurosProduto
{
    public class ICB : ImpostoProduto
    {
        public ICB()
        {
        }

        public ICB(ImpostoProduto outroImposto) : base(outroImposto)
        {
        }
        public override double Calcular(Produto produto)
        {
            return (produto.Valor * 0.1) + CalcularOutroImposto(produto);
        }
    }
}
