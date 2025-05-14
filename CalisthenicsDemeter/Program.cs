using CalisthenicsDemeter;
using CalisthenicsDemeter.ValueObjets;


CarrinhoCompras carrinhoCompras = new CarrinhoCompras();
carrinhoCompras.Calcular(new Pedido(new Cliente("Leonardo",new EnderecoInfo("Rua Sem saída","JD Arraial","Osasco","5456","Osasco","SP","045555-165"))));
Console.WriteLine("Hello, World!");
