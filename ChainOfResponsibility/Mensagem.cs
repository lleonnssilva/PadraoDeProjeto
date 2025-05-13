namespace StrategyEnvioMensagem
{
    public class Mensagem
    {
        public Mensagem(string destino, string texto)
        {
            Destino = destino;
            Texto = texto;
        }

        public String  Destino  { get; set; }
        public String Texto { get; set; }
    }
}