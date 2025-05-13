namespace StrategyEnvioMensagem
{
    public class MensagemPush : IEnvio
    {
        public IEnvio ProximoEnvio { get ; set; }

        public IEnvio CriarEnvio(string tipo)
        {
            if (tipo != "push")
                return ProximoEnvio.CriarEnvio(tipo);
            return this;
        }

        public void EnviarMensagem(List<Mensagem> mensagens)
        {
            Console.WriteLine("Início de envio de mensagens por Push");
            Console.WriteLine("----------------");
            foreach (var msg in mensagens)
            {
                Console.WriteLine(String.Format("Id:{0}\nTipo:Push\nDestino:{1}\nMensagem:{2}", msg.GetHashCode(), msg.Destino, msg.Texto));
                Console.WriteLine("----------------");
            }
            Console.WriteLine("Término de envio de mensagens por Push");

        }
    }
}
