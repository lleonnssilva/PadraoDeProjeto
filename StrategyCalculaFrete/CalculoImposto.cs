namespace StrategyCalculaImposto
{
    public class CalculoImposto
    {
        private ICalculoImposto _calculoImposto;

        public void SetarTipoImposto(ICalculoImposto imposto)
        {
            _calculoImposto = imposto;
        }

        public double RetornalTotalImposto(double total)
        {
            if (_calculoImposto != null)
                return total + _calculoImposto.CalcularImposto(total);
            return total;
        }


    }
}
