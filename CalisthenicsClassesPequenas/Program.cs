

using CalisthenicsClassesPequenas;
using CalisthenicsClassesPequenas.ValueObjets;

try
{
    Cliente cliente = new Cliente("Leonardo", new ContatoInfo(new TelefoneInfo("11 954564664"),new EmailInfo("leoguaruleo@gmil.com")), new EnderecoInfo("Rua 10","Jd.Laranjeiras","Nova Iguaçu","3345","Rio de Janeiro","RJ"));

    Console.WriteLine($"Dados do Cliente\nNome: {cliente.GetNome()}\nTelefone: {cliente.GetTelefone()}\nEmail: {cliente.GetEmail()}\nEndereço:\n{cliente.GetEnderecoFormatado()}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
