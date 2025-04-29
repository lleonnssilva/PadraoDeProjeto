namespace StrategyEnvioMensagem
{
    public class Envio
    {
        public void EnviarMensagem(List<Mensagem> mensagens, string tipo)
        {
            IEnvio mensagem;
            if (tipo == "email")
            {
                mensagem = new MensagemEmail();
                mensagem.EnviarMensagem(mensagens);
            }
            else if (tipo == "sms")
            {
                mensagem = new MensagemSms();
                mensagem.EnviarMensagem(mensagens);
            }
            else if (tipo == "push")
            {
                mensagem = new MensagemPush();
                mensagem.EnviarMensagem(mensagens);
            }
        }
    }
}
