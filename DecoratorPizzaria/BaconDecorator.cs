﻿namespace DecoratorPizzaria
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com porção extra de bacon";
            return pizza;

        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00m;
            return preco;
        }
    }
}
