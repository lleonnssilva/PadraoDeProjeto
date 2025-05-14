namespace CommandRestaurante
{
    //Invoker
    public class Garcom
    {
        private Pedido _pedido;

        public Garcom(Pedido pedido)
        {
            this._pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Execute();
        }
    }
}
