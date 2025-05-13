using CommandRestaurante;

class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef();

        //Prato principal
        Pedido pedido = new Pedido(chef, "prato");
        Garcom garcom = new Garcom(pedido);
        garcom.Executar();

        pedido = new Pedido(chef, "sobremesa");
        garcom = new Garcom(pedido);
        garcom.Executar();


        Console.ReadKey();
    }

}