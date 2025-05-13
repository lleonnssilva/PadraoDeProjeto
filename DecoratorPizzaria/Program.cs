using DecoratorPizzaria;

class Program
{
    static void Main(string[] args)
    {
        IPizza pizza = new Pizza();
        Console.WriteLine(pizza.Opcionais());
        Console.WriteLine($"preço R$ {pizza.Preco()}\n");
        Console.WriteLine("Tecle algo para plicar o padrão Decorator");
        Console.ReadKey();

        Console.WriteLine("------------- Aplicando o Decorator ---------------");
        IPizza pizza2 = new Pizza();
        IPizza massaEspecial = new MassaEspecialDecorator(pizza2);
        IPizza baconDecoRator = new BaconDecorator(massaEspecial);
        IPizza bordaDecortor = new BordaRecheadaDecorator(baconDecoRator);

        Console.WriteLine(bordaDecortor.Opcionais());
        Console.WriteLine($"preço Total R$ : {bordaDecortor.Preco()}");
        Console.ReadKey();
    }
}
