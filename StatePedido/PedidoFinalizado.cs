namespace StatePedido
{
    public class PedidoFinalizado : IEstadoPedido
    {
        public void Aprovado(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado não podem ser aprovado");
        }

        public void EmAndamento(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado não podem ir pra andamento");
        }

        public void Finalizado(Pedido pedido)
        {
            throw new Exception("Pedido já está finalizado");
        }

        public void Reprovado(Pedido pedido)
        {
            throw new Exception("Pedido já foi finalizado não podem ir pra reprovado");
        }
    }
}