namespace StrategyCalculaImposto
{
    public class ICMS : ICalculoImposto
    {
        
        public double CalcularImposto(double valorTotal)
        {
          
            
            return (valorTotal * 12)/100;
        }
    }
}
