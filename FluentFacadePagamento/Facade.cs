namespace FluentFacadePagamento
{
    public class Facade
    {
        public bool Pagar(string cpf, FormaDePagamento formaDePagamento, int valor)
        {
            return ProcessadorDePagmentos.Build()
                    .DefinirCliente(CarregarCliente(cpf))
                        .DefinirFormaDePagamento(formaDePagamento)
                            .Pagar(valor);

        }

        private Cliente CarregarCliente(string cpf)
        {
            return Cliente.Build()
                .DefinirNome("Leonardo Leite")
                .DefinirCpf(cpf)
                .DefinirTelefone("11986646546")
                .DefinirEmail("leoguaruleo@gmail.com")
                .DefinirIdade(48);
        }
    }
}
