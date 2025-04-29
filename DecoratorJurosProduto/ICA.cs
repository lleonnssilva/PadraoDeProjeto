namespace DecoratorJurosProduto
{
    public class ICA : ImpostoProduto
    {
        public ICA()
        {
        }
        public ICA(ImpostoProduto outroImposto):base(outroImposto)
        {
        }
        public override double Calcular(Produto produto)
        {
            return (produto.Valor * 0.15) + CalcularOutroImposto(produto);
        }

       
    }
}
