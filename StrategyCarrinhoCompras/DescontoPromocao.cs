namespace StrategyCarrinhoCompras
{
    public class DescontoPromocao : IDescontoStratregy
    {
        public double AplicarDesconto(double valorOriginal)
        {
            // Aplica um desconto fixo de 10%
            return valorOriginal - (valorOriginal * 10 / 100);
        }
    }
}

