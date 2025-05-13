
using StrategyCalculaImposto;

class Program
{

    static void Main(string[] args)
    {

        try
        {

            var totalPedido = 100.8;
            CalculoImposto calculo = new CalculoImposto();
            calculo.SetarTipoImposto(new ICMS());
            var totalICMS = calculo.RetornalTotalImposto(totalPedido);

            calculo.SetarTipoImposto(new IPI());
            var totalIPI = calculo.RetornalTotalImposto(totalPedido);

            //Exibir Total do pedido
            Console.WriteLine($"Total do pedido: {totalPedido}");

            //Exibir calculo do frete com ICMS
            Console.WriteLine($"Total do pedido com Imposto ICMS: {totalICMS}");

            //Exibir calculo do frete com IPI
            Console.WriteLine($"Total do pedido com Imposto IPI: {totalIPI}");


        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

}