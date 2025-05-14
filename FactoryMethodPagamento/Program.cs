using FactoryMethodPagamento;

Creator creator = new ConcreteCreator();
var pagamento = creator.FactoryMethod();
pagamento.Pagar(25);