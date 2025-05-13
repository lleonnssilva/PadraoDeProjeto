namespace DecoratorJurosProduto
{
    public class ICC : ImpostoProduto
    {
        public ICC()
        {
        }

        public ICC(ImpostoProduto outroImposto) : base(outroImposto)
        {
        }
        public override double Calcular(Produto produto)
        {
            return (produto.Valor * 0.05) + CalcularOutroImposto(produto);
        }
    }
}
