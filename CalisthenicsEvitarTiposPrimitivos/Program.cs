
using CalisthenicsEvitarTiposPrimitivos;
using CalisthenicsEvitarTiposPrimitivos.ValueObjets;

try
{
    Cliente cliente = new Cliente("Leonardo", new Emailnfo("leoguaruleo@gmil.com"), new CpfInfo("252.153.448-09"), new IdadeInfo(48));
    Console.WriteLine($"Dados do Cliente\nNome: {cliente.GetNome()}\nEmail: {cliente.GetEmail()}\nCpf: {cliente.GetCpf()}\nIdade: {cliente.GetIdade()}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}


