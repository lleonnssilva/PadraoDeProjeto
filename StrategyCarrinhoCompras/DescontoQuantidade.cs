namespace StrategyCarrinhoCompras
{
    public class DescontoQuantidade:IDescontoStratregy
    {
        private int _quantidade;

        public DescontoQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        public double AplicarDesconto(double valorOriginal)
        {
            // Se a quantidade de itens for maior que 10, dá um desconto de 15%
            if (_quantidade > 10)
            {
               return  valorOriginal - (valorOriginal * 15 / 100);
            }
            return valorOriginal;
        }
    }
}
