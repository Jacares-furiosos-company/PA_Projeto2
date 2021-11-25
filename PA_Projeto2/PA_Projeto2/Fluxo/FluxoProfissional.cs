using System;
using PA_Projeto2.Helpers;
using PA_Projeto2.Objetos;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    class FluxoProfissional
    {
        public static void FluxoPrincipal(string usuario)
        {
            try
            {
                Console.Write("═══════════════════════════════════════════════════");
                Console.WriteLine("Outro número para sair ");
                Console.WriteLine("Digite 1 para Serviços ");
                Console.WriteLine("Digite 2 para Sair ");
                int escolha = int.Parse(Console.ReadLine());
            
                if(escolha == 1)
                {
                    procurarServicos();
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Opção Invalida !");
            }
        }

        private static void procurarServicos()
        {
            Console.WriteLine("═══════════════════════════════════════════════════");
            Console.WriteLine(" === Serviços Disponiveis === ");

            foreach (var item in Program.dadosUsuarios.Usuarios)
            {
                if (item.TipoConta == 1)
                {
                    Console.WriteLine("═══════════════════════════════════════════════════");
                    Console.WriteLine($"Nome do usuário: {item.NomeUsuario}");
                    Console.WriteLine($"Estrelas: {item.Estrelas}");
                }
            }

            Console.WriteLine("Muito Obrgiado !");
            Console.WriteLine("Agora voce Será Redirecionado para a tela Princiapal");
            Console.WriteLine("Aperte Enter !");
            string _ = Console.ReadLine();
            Console.Clear();
            FluxoLogin fluxoLogin = new FluxoLogin();
            fluxoLogin.Menu();
        }
    }
}
