namespace StrategyCalculaImposto
{
    public class IPI : ICalculoImposto
    {
        public double CalcularImposto(double valorTotal)
        {
            return (valorTotal * 5)/100;
        }
    }
}
