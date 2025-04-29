namespace StatePedido
{
    public class PedidoAprovado : IEstadoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido já está em estado de aprovação");
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
            throw new Exception("Pedido está em estado aprovação e não pode ser reprovado");
        }
    }
}