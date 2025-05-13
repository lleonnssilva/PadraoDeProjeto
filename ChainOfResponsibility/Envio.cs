namespace StrategyEnvioMensagem
{
    public class Envio
    {
        public void EnviarMensagem(List<Mensagem> mensagens, string tipo)
        {
            var mensagemEmail = new MensagemEmail();
            var mensagemSms = new MensagemSms();
            var mensagemPush = new MensagemPush();
            var mensagemSemCanal = new MensagemSemCanal();

            mensagemEmail.ProximoEnvio = mensagemSms;
            mensagemSms.ProximoEnvio = mensagemPush;
            mensagemPush.ProximoEnvio = mensagemSemCanal;


            var envio = mensagemEmail.CriarEnvio(tipo);
            envio.EnviarMensagem(mensagens);

        }
    }
}
