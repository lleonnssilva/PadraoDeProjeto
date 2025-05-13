namespace StrategyEnvioMensagem
{
    public interface IEnvio
    {
        void EnviarMensagem(List<Mensagem> mensagens);
        IEnvio CriarEnvio(string tipo);
        IEnvio ProximoEnvio{ get; set; }
    }
}
