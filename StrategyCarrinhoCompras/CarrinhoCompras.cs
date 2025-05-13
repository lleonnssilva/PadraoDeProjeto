namespace StrategyCarrinhoCompras
{
    public class CarrinhoCompras
    {
        private List<Produto> _produtos;
        private IDescontoStratregy _descontoStrategy;

        public CarrinhoCompras()
        {
            _produtos = new List<Produto>();
        }

        public void AdicionarProdutos(List<Produto> produtos)
        {
            _produtos.AddRange(produtos);
        }

        public void SetarDesconto(IDescontoStratregy descontoStrategy)
        {
            _descontoStrategy = descontoStrategy;
        }

        public double CalcularTotal()
        {
            double total = _produtos.Sum(p => p.CalcularPrecoTotal());
            if (_descontoStrategy != null)
            {
                total = _descontoStrategy.AplicarDesconto(total);
            }
            return total;
        }
    }
}