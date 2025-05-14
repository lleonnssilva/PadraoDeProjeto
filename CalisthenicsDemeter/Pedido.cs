namespace CalisthenicsDemeter
{
    public class Pedido
    {
        private Cliente _cliente;

        public Pedido(Cliente cliente)
        {
            this._cliente = cliente;
        }
        public string GetCepClente()
        {
            return _cliente.GetCep();
        }
    }
}
