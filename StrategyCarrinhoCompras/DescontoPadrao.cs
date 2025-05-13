namespace StrategyCarrinhoCompras
{
    public class DescontoPadrao : IDescontoStratregy
    {
        public double AplicarDesconto(double valorOriginal)
        {
            // Aplica um desconto fixo de 5%
            return valorOriginal - (valorOriginal * 5/100);
        }
    }
}
