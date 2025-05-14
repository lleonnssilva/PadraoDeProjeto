namespace CommandRestaurante
{
    //Concrete Command
    public class Pedido : ICommand
    {
        private Chef _chef;
        private string _acao { get; set; }
        public Pedido(Chef chef, string acao)
        {
            this._chef = chef;
            this._acao = acao;
        }

       
        public void Execute()
        {
            if (this._acao == "prato")
            {
                _chef.PreparandoPrato();
            }
            else
            {
                _chef.PreparandoSobremesa();
            }
              
           
        }
    }
}
