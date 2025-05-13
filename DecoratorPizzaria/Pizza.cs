namespace DecoratorPizzaria
{
    public class Pizza : IPizza
    {
        public decimal Preco()
        {
            var preco = 10.00m;
            return preco;
        }

        public string Opcionais()
        {
            var pizza = "Pizza padrão";
            return pizza;
        }
    }
}
