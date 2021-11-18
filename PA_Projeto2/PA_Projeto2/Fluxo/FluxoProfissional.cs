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
            Console.WriteLine("Outro número para sair");
            Console.WriteLine("1:Procurar Serviços");
            int escolha = int.Parse(Console.ReadLine());
            
            if(escolha == 1)
            {
                procurarServicos();
            }
        }

        private static void procurarServicos()
        {
            Console.WriteLine("Serviços Disponiveis");
            foreach(var item in Program.dadosUsuarios.Usuarios)
            {
                if(item.TipoConta == 1)
                {
                    Console.WriteLine($"Nome do usuário: {item.NomeUsuario}" );
                    Console.WriteLine($"Estrelas: {item.Estrelas}");
                }
            }
        }


    }
}
