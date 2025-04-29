namespace StatePedido
{
    public class PedidoReprovado : IEstadoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido está em estado reprovado não pode ser aprovado");
        }

        public void EmAndamento(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoEmAndamento();
        }

        public void Finalizado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoFinalizado();
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedido está reprovado");
        }
    }
}