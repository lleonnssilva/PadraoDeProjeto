﻿namespace DecoratorPizzaria
{
    public class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\r\n com massa especial";
            return pizza;

        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 2.50m;
            return preco;
        }
    }
}
