namespace StrategyEnvioMensagem
{
    public class MensagemSemCanal : IEnvio
    {


        public IEnvio ProximoEnvio { get ; set ; }
        public IEnvio CriarEnvio(string tipo)
        {
            return this;
        }

        public void EnviarMensagem(List<Mensagem> mensagens)
        {
           
            Console.WriteLine("Mensagens de envio não possue canal");

        }
    }
}
