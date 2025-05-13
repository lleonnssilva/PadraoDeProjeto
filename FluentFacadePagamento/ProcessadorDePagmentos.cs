namespace FluentFacadePagamento
{
    public class ProcessadorDePagmentos
    {
        Cliente _cliente = new Cliente();
        FormaDePagamento _formaDePagamento = new FormaDePagamento();
        bool _validacoes = true;

       
        public static ProcessadorDePagmentos Build()
        {
            return new ProcessadorDePagmentos();
        }
        public ProcessadorDePagmentos DefinirFormaDePagamento(FormaDePagamento formaDePagamento)
        {
            Console.WriteLine($"Forma de Pagmento:{formaDePagamento}");
            this._formaDePagamento = formaDePagamento;
            return this;
        }
        public ProcessadorDePagmentos DefinirCliente(Cliente cliente)
        {
            this._cliente = cliente;
            return this;
        }
        public bool Pagar(int valor)
        {
            this.ValidarPagamento(valor).EnviarParaDERP();
           
            return this._validacoes;
        }

        private ProcessadorDePagmentos ValidarPagamento(int valor)
        {
            if (!this._validacoes) return this;

            Console.WriteLine($"Pagamento validado para o cliente:{this._cliente.Nome}");
            this._validacoes = this._validacoes && true;
            return this;
        }

        private ProcessadorDePagmentos EnviarParaDERP()
        {
            if (!this._validacoes) return this;

            Console.WriteLine($"Pagamento enviado para o ERP: {this._cliente.Nome}");
            this._validacoes = this._validacoes && true;

            return this;
        }
    }
}
