
using StrategyEnvioMensagem;

//-Permite que um objeto passe uma solicitação a uma cadeia de objetos até que um deles processe a solicitação. 
//-Isso é útil para reduzir o acoplamento entre os objetos que fazem parte dessa cadeia

Console.WriteLine("Inicando o programa");
var mensagens = new List<Mensagem>();
mensagens.Add(new Mensagem("fghfgjghjgfhjgfhjgh", "Mensagem de sms 1"));
mensagens.Add(new Mensagem("kjghkjhuyiioio", "Mensagem de sms 2"));
mensagens.Add(new Mensagem("fdsfsdfsdfws", "Mensagem de sms 3"));

var envioMensagem = new Envio();
envioMensagem.EnviarMensagem(mensagens, "sms");
Console.ReadKey();