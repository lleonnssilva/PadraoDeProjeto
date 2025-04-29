namespace StrategyEnvioMensagem
{
    public class MensagemEmail : IEnvio
    {
        public MensagemEmail()
        {
        }

        public void EnviarMensagem(List<Mensagem> mensagens)
        {
            Console.WriteLine("Início de envio de mensagens por Email");
            Console.WriteLine("----------------");
            foreach (var msg in mensagens)
            {
                Console.WriteLine(String.Format("Id:{0}\nTipo:Email\nDestino:{1}\nMensagem:{2}", msg.GetHashCode(), msg.Destino, msg.Texto));
                Console.WriteLine("----------------");
            }
            Console.WriteLine("Término de envio de mensagens por Email");

        }
    }
}
