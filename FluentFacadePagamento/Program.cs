using FluentFacadePagamento;

class Program
{
    static void Main(string[] Args) 
    {
        Facade facade = new Facade();
        facade.Pagar("25215344809", FormaDePagamento.aplicativo, 4466);
        Console.ReadKey();
    }
}