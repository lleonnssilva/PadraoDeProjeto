namespace CalisthenicsEvitarGettersSetters
{
    public class Produto
    {
        public double Preco { get; private set; }

        public void AlterarPreco(double preco)
        {
            if (preco <= 0)
                throw new Exception("Erro:O preço deve ter valor positivo!");
            this.Preco = preco;
        }
        public double AplicarDesconto(double desconto)
        {

            if (desconto > this.Preco)
                throw new Exception("Erro:O desconto não deve ter valor maior que o preço!");

            if (desconto <= 0)
                throw new Exception("Erro:O preço deve ter valor positivo!");

            if (desconto >= 50)
            {
                this.Preco = this.Preco - desconto;
            }


            return this.Preco;
        }
    }
}
