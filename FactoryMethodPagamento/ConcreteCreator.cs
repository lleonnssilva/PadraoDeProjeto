namespace FactoryMethodPagamento
{
    public class ConcreteCreator : Creator
    {
        public override PagamentoProduct FactoryMethod()
        {
            return new PagamentoContaInternacional();
        }
    }
}
