﻿
namespace StatePedido
{
    public class Pedido
    {
        public Pedido(string descricao, double valorProduto)
        {
            Descricao = descricao;
            ValorProduto = valorProduto;
            EstadoAtual = new PedidoEmAndamento();
        }

        public string Descricao  { private  get; set; }
        public double ValorProduto { private get; set; }
        public IEstadoPedido EstadoAtual { private get; set; }

        public void Aprovado()
        {
            EstadoAtual.Aprovado(this);
            Console.WriteLine("Pedido aprovado");
        }


        public void EmAndamento()
        {
            EstadoAtual.EmAndamento(this);
            Console.WriteLine("Pedido em andamento");
        }



        public void Finalizado()
        {
            EstadoAtual.Finalizado(this);
            Console.WriteLine("Pedido finalizado");
        }

        public void Reprovado()
        {
            EstadoAtual.Reprovado(this);
            Console.WriteLine("Pedido reprovado");
        }

    }
}
