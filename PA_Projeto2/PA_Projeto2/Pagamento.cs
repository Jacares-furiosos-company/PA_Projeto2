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
            try
            {
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine($" Profissional Escolhido, {profissional.NomeUsuario}");
                Console.WriteLine(" Digite 1 Para Pagamento com Cartão");
                Console.WriteLine(" Digite 2 Para Pagamento no Boleto");
                Console.WriteLine(" Enter Para Cancelar");
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
                    Cartao cartao = new Cartao();
                    if(cartao.CancelarCompra() == true)
                    {
                        Console.WriteLine("═══════════════════════════════════════════════════");
                        Console.WriteLine("Compra Cancelada");
                        Console.WriteLine("Voltando para a tela principal ");
                        Console.WriteLine("Aperte Enter !");
                        string _ = Console.ReadLine();
                        FluxoCliente.FluxoPrincipal();
                    }
                    else
                    {
                        Console.WriteLine("Compra não Foi cancelada, e o Pedido sera Processado !");

                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Opção Invalida !");

            }
            
        }



        private static void PagamentoPorCartao()
        {

            Cartao cartao = new Cartao();
            FluxoLogin fluxoLogin = new FluxoLogin();
            try
            {
                if (cartao.ValidarCartao() == true)
                {
                    cartao.PagamentoCartao();
                }
                else
                {
                    fluxoLogin.Menu();
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Opção Invalida !");
            }
        }

        private static void PagamentoPorBoleto()
        {
            Random randNum = new Random();

            int cod_Pagamento1 = randNum.Next(0, 9);
            int cod_Pagamento2 = randNum.Next(100000, 999999);
            int cod_Pagamento3 = randNum.Next(100000, 999999);
            int cod_Pagamento4 = randNum.Next(10, 99);

            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine("Realize o Pagamento através do Codigo de Barra abaixo!");
            Console.WriteLine("Código de barra >> {0} || {1} || {2} || {3} << ", cod_Pagamento1, cod_Pagamento2, cod_Pagamento3, cod_Pagamento4);
            Console.WriteLine("Digite Enter para Continuar");
            string _ = Console.ReadLine();
        }
    }
}
