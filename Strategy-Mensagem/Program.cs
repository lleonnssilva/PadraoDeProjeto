
using StrategyEnvioMensagem;

//-Quando há  necessidade de extender a mesma funcionalidade para implementação distinta
//-Define uma família de algoritmos, garantindo que o algoritmo varie independentemente dos clientes que fazem uso dele
//-No exemplo temos o método de envio mensagem que pode ser implementado para atender varios tipos de mensagem, sendo por email,sms e push, ou seja,cada tipo de envio com a sua implementação.

Console.WriteLine("Inicando o programa");
var mensagens = new List<Mensagem>();
mensagens.Add(new Mensagem("leoguaruleo@gmail.com", "Mensagem 1"));
mensagens.Add(new Mensagem("leo2025@gmail.com", "Mensagem  2"));
mensagens.Add(new Mensagem("leonsilva@gmail.com", "Mensagem 3"));

var envioMensagem = new Envio();
envioMensagem.EnviarMensagem(mensagens, new MensagemPush());
Console.ReadKey();