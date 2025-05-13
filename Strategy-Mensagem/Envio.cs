namespace StrategyEnvioMensagem
{
    public class Envio
    {
  
        public void EnviarMensagem(List<Mensagem> mensagens, IEnvio envio)
        {
            envio.EnviarMensagem(mensagens);
        }

    }
}
