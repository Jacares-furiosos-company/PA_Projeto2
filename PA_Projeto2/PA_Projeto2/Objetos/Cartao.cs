using System;
using System.Collections.Generic;
using System.Text;
using PA_Projeto2.Helpers;
using PA_Projeto2.Interfaces;
using PA_Projeto2.Objetos;

namespace PA_Projeto2
{
    class Cartao : ICartao
    {
        string numeroCartao;
        int cvv;
        string dataValidade;
        public void Card(string cartaoDeCredito, int cvv, string dataValidade)
        {
            this.numeroCartao = cartaoDeCredito;
            this.cvv = cvv;
            this.dataValidade = dataValidade;
        }

        public Boolean CancelarCompra()
        {
            try
            {
                Console.Write("═══════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deseja Realmente Cancelar sua compra ?");
                Console.WriteLine("Digite 1 para - Sim");
                Console.WriteLine("Digite 2 para - Não");

                Console.ForegroundColor = ConsoleColor.White;
                int cancela = int.Parse(Console.ReadLine());

                if (cancela == 1)
                {
                    Console.Write("═══════════════════════════════════════════════════");
                    Console.WriteLine("Obrigado !");
                    Console.WriteLine("Compra Cancelada");
                    Console.WriteLine("Agora Voce será redirecionado para a Tela Principal !");
                    Console.WriteLine("Aperte Enter !");
                    string _ = Console.ReadLine();
                    FluxoLogin fluxoLogin = new FluxoLogin();
                    fluxoLogin.Menu();
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção Invalida.");
            }

            return false;
        }

        public void PagamentoCartao()
        {   
            bool Bolean = true;

            while (Bolean)
            {
                try
                {
                    Console.WriteLine("═══════════════════════════════════════════════════");
                    Console.WriteLine("Digite 1 Para Opção de Debito !");
                    Console.WriteLine("Digite 2 Para Opção de Credito !");
                    int escolha = int.Parse(Console.ReadLine());

                    if(escolha == 1)
                    {
                        Random numAleatorio = new Random();
                        int valorInteiro = numAleatorio.Next();
                        Console.WriteLine("═══════════════════════════════════════════════════");
                        Console.WriteLine("Obrigado por Escolhar nossa Plataforma !");
                        Console.WriteLine("Salve o numero do Seu pagamento : {0}", valorInteiro);

                        Bolean = false;
                    }
                    else if (escolha == 2)
                    {
                        Random numAleatorio = new Random();
                        int valorInteiro = numAleatorio.Next();
                        Console.WriteLine("═══════════════════════════════════════════════════");
                        Console.WriteLine("");
                        Console.WriteLine("Obrigado por Escolhar nossa Plataforma !");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seu pagamento tem 0.5% de Juro");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Salve o numero do Seu pagamento : {0}", valorInteiro);
                        Bolean = false;
                    }
                    else
                    {
                        Console.WriteLine("Voce precisa Escolha uma opção de Pagamento");
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine("Opção invalida !");
                }

            }

        }

        public Boolean ValidarCartao()
        {
            var nome = HelperManipulaDados.nomeUsuario;
            Cliente usuario = (Cliente)HelperManipulaDados.BuscaUsuario(nome);

            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.Write("Digite o numero do seu cartão Para Verificação de Segurança");
            string numeroCartao = Console.ReadLine();

            if (usuario.CartaoDeCredito.numeroCartao == numeroCartao)
            {
                Console.Write("Compra Validada com Sucesso !");
                return true;
            }
            else
            {
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine("Compra não passou na Verificação de Segurança");
                Console.WriteLine("Voçe será Levado para a Tela princiapal");
                Console.Clear();
                FluxoLogin fluxoLogin = new FluxoLogin();
                fluxoLogin.Menu();
                return false;
            }

        }

        public string NumeroCartao { get => numeroCartao; set => throw new NotImplementedException(); }
        public int Cvv { get => cvv; set => throw new NotImplementedException(); }
        public string DataValidade { get => dataValidade; set => throw new NotImplementedException(); }

    }
}
