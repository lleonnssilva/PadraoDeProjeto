using StrategyCarrinhoCompras;

class Program
{

    static void Main(string[] args)
    {

        try
        {
            var carrinho = new CarrinhoCompras();

            // Criar alguns produtos
            var calca = new Produto("Calça", 100.33, 2); 
            var camisa = new Produto("Camisa", 50.99, 3); 
            var tenis = new Produto("Tênis", 301.60, 1);
            var bermuda = new Produto("Bermuda", 206.30, 2);
            var bone = new Produto("Boné", 50.50, 3);
            var cinto = new Produto("Cinto", 15.5, 1);

            List<Produto> produtos = new List<Produto>();
            // Adicionar produtos ao carrinho
            produtos.Add(calca);
            produtos.Add(camisa);
            produtos.Add(tenis);
            produtos.Add(bermuda);
            produtos.Add(bone);
            produtos.Add(cinto);

            carrinho.AdicionarProdutos(produtos);

            //Exibir os itens do carrinho de compras 
            Console.WriteLine("Produtos o carrinho de compras:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Nome} - {produto.Quantidade}x{produto.Preco} = {(produto.Preco*produto.Quantidade)}");

            }
            Console.WriteLine("---------------");
            // Exibir total original
            Console.WriteLine("Valor Original: " + carrinho.CalcularTotal().ToString("#.##"));

            // Exemplo de desconto padrão
            carrinho.SetarDesconto(new DescontoPadrao());
            Console.WriteLine("Desconto Padrão (5%): " + carrinho.CalcularTotal().ToString("#.##"));

            // Exemplo de desconto de promoção
            carrinho.SetarDesconto(new DescontoPromocao());
            Console.WriteLine("Desconto de Promoção (10%): " + carrinho.CalcularTotal().ToString("#.##"));

            // Exemplo de desconto por quantidade (10 itens)
            var descontoQuantidade = new DescontoQuantidade(12);
            carrinho.SetarDesconto(descontoQuantidade);
            Console.WriteLine("Desconto por Quantidade maior ou igual a 10 itens (15%): " + carrinho.CalcularTotal().ToString("#.##"));

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

}