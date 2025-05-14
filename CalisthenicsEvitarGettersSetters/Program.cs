using CalisthenicsEvitarGettersSetters;

try
{
    Produto produto = new Produto();
    produto.AlterarPreco(1);
    Console.WriteLine($" O Preço do produto é {produto.Preco}");
    produto.AplicarDesconto(-1);

    Console.WriteLine($" O Preço do produto com desconto  é {produto.Preco}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


