namespace DecoratorJurosProduto
{
    public abstract class ImpostoProduto
    {
        private ImpostoProduto _outroImposto;

        protected ImpostoProduto()
        {
            _outroImposto = null;
        }

        protected ImpostoProduto(ImpostoProduto outroImposto)
        {
            _outroImposto = outroImposto;
        }
        public abstract double Calcular(Produto produto);
        protected  double CalcularOutroImposto(Produto produto)
        {
            if (_outroImposto == null)
                return 0;
            return _outroImposto.Calcular(produto);
        }
    }
}
