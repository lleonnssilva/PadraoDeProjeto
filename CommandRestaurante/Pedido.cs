namespace CommandRestaurante
{
    //Concrete Command
    public class Pedido : ICommand
    {
        public Pedido(Chef chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }

        private Chef Chef { get; set; }
        private string Acao { get; set; }
        public void Execute()
        {
            if (Acao == "prato")
            {
                Chef.PreparandoPrato();
            }
            else
            {
                Chef.PreparandoSobremesa();
            }
              
           
        }
    }
}
