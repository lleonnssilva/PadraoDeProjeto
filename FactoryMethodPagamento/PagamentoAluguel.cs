namespace FactoryMethodPagamento
{
    public class PagamentoAluguel : PagamentoProduct
    {
        public PagamentoAluguel()
        {
            this._descricao = "Aluguel";
            this._tipo = "Boleto";
        }
        public override void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento da conta {this._descricao} do tipo {this._tipo} no valor de {valor} reais");
        }
    }
}
