namespace CommandRestaurante
{
    //Invoker
    public class Garcom
    {
        private Pedido pedido;

        public Garcom(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executar()
        {
            pedido.Execute();
        }
    }
}
