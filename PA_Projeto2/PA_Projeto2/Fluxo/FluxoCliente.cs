using PA_Projeto2.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    class FluxoCliente
    {
        public static void FluxoPrincipal()
        {
            Console.WriteLine("Opções");
            ContratarServico();
        }
        public static void ContratarServico()
        {
            Console.WriteLine("Qual tipo de serviço você deseja?");
            Console.WriteLine("1:Mecânico");
            Console.WriteLine("2:Encanador");
            Console.WriteLine("3:Eletricista");
            Console.WriteLine("4:Marceneiro");
            Console.WriteLine("5:Pedreiro de acabamento");
            int escolha = int.Parse(Console.ReadLine());
            MostraProfissionais(escolha);
        }
        
        public static void MostraProfissionais(int escolha)
        {
            var profissionais = Program.dadosUsuarios.Usuarios.FindAll(x => x.TipoConta == 2);
            foreach(Profissional item in profissionais)
            {
                if(item.Especialidades.ContainsKey(escolha))
                {
                    Console.WriteLine(item.NomeUsuario);
                }
               
            }
      
        }
        
    }
}
