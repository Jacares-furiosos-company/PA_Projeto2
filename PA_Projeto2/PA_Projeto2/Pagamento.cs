using PA_Projeto2.Objetos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    class Pagamento
    {
        public static void EscolherPagamento(Profissional profissional)
        {
            Console.WriteLine($"Profissional Escolhido {profissional.NomeUsuario}");
            Console.WriteLine("1:Cartão de Crédito");
            Console.WriteLine("2:Boleto");
            Console.WriteLine("Outra número para cancelar a compra");
            int escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                PagamentoPorCartao();
            }
            else if(escolha == 2)
            {
                PagamentoPorBoleto();
            }
            else
            {
                Console.WriteLine("Compra Cancelada");
                Console.WriteLine("Voltando para a tela principal ");
                FluxoCliente.FluxoPrincipal();
            }
            
        }



        private static void PagamentoPorCartao()
        {
            Console.WriteLine("Pagamento Por Cartão Realizado");
        }

        private static void PagamentoPorBoleto()
        {
            Console.WriteLine("Pagamento Por Boleto Realizado");
        }
    }
}
