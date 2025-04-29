namespace StatePedido
{
    public class PedidoEmAndamento : IEstadoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoAprovado();
        }

        public void Finalizado(Pedido pedido)
        {
            throw new Exception("Pedido em andamento não pode ser finalizado");
        }

        public void Reprovado(Pedido pedido)
        {
            pedido.EstadoAtual = new PedidoReprovado();
        }

        void IEstadoPedido.EmAndamento(Pedido pedido)
        {
            return;
        }
    }
}