//Introduz uma flexibilidade na composição dos objetos, bastando escolher o momento da instanciação
using DecoratorJurosProduto;
class Program
{

    static void Main(string[] args)
    {

        var produto = new Produto("Camisa social", 300);
        var imposto = new ICB(new ICC(new ICA()));
        try
        {
            var valorImposto = imposto.Calcular(produto);
            Console.WriteLine($"O Valor do imposto é {valorImposto}");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

}
