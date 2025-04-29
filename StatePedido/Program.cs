//Objetivo de auxiliar e manter o controle dos estados e organiza-los através de criçõ de classes que represent cada estado e saiba controlr as transações
//O exemplo de pedido onde possue 4 estados e dependendo do estado que ele está não pode ser alterado
//Caminhos permitidos:
//EmAndamento>>Aprovado>>Finalizado
//EmAndamento>>Reprovado>>Finalizado
//Qualquer caminho diferente desse gera-se uma execessão
using StatePedido;

class Program
{
    
    static void Main(string[] args)
    {
       
        var pedido = new Pedido("Camisa social", 200);
       
        try
        {
            pedido.EmAndamento();
            pedido.Aprovado();
            pedido.Finalizado();
           
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

}
