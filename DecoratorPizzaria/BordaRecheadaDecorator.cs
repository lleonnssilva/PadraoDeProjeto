using System.ComponentModel.DataAnnotations;

namespace DecoratorPizzaria
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com borda recheada";
            return pizza;

        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco+= 3.00m;
            return preco;
        }
    }
}
