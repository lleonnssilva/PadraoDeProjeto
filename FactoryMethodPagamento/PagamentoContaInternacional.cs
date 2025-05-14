namespace FactoryMethodPagamento
{

    public class PagamentoContaInternacional : PagamentoProduct
    {
        public PagamentoContaInternacional()
        {
            this._descricao = "Compras internacionais";
            this._tipo = "Cartão de crédito";
        }
        public override void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento da conta {this._descricao} do tipo {this._tipo} no valor de {valor} dólares");
        }
    }
}
