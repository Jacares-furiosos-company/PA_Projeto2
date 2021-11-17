using PA_Projeto2.Objetos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    class FluxoCliente
    {
        Pagamento pagamento = new Pagamento();
        public static void FluxoPrincipal()
        {
            Console.WriteLine("Opções");

            var profissionais = EncontrarProfissionais();
            var especialidadeEscolhida = EscolherEspecialidade();
            var profissionaisTipo = MostraProfissionais(especialidadeEscolhida, profissionais);
            var profissionalEscolhido = EscolhaDoProfissional(profissionaisTipo, especialidadeEscolhida);

            Pagamento.EscolherPagamento(profissionalEscolhido);
            AvaliarServico(profissionalEscolhido);
        }
        private static List<Usuario> EncontrarProfissionais()
        {
            var profissionais = Program.dadosUsuarios.Usuarios.FindAll(x => x.TipoConta == 2);
            return profissionais;
        }
        private static int EscolherEspecialidade()
        {
            Console.WriteLine("Qual tipo de serviço você deseja?");
            Console.WriteLine("1:Mecânico");
            Console.WriteLine("2:Encanador");
            Console.WriteLine("3:Eletricista");
            Console.WriteLine("4:Marceneiro");
            Console.WriteLine("5:Pedreiro de acabamento");
            int escolha = int.Parse(Console.ReadLine());
            return escolha;
           
        }
        private static List<Profissional> MostraProfissionais(int escolha, List<Usuario> profissionais)
        {
            List<Profissional> profissionaisEncontrados = new List<Profissional>();
            foreach(Profissional item in profissionais)
            {
                if(item.Especialidades.ContainsKey(escolha))
                {
                    profissionaisEncontrados.Add(item);
                    Console.WriteLine($"--------------------------------------");
                    Console.WriteLine($"Nome Do Profissional:{item.NomeUsuario}");
                    Console.WriteLine($"ID do usuário:{item.IdUsuario}");
                    Console.WriteLine($"--------------------------------------");
                }              
            }
            return profissionaisEncontrados;                     
        }


        private static Profissional EscolhaDoProfissional(List<Profissional> profissionaisEncontrados, int especialidadeEscolhida)
        {
            Profissional profissionalEscolhido;
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Escolha o profissional que deseja contratar pelo seu id");
                int escolha = int.Parse(Console.ReadLine());
                profissionalEscolhido = profissionaisEncontrados.FirstOrDefault(x => x.IdUsuario == escolha);
                if (profissionalEscolhido == null || profissionalEscolhido.TipoConta == 1 ||!profissionalEscolhido.Especialidades.ContainsKey(especialidadeEscolhida))
                {
                    Console.WriteLine("Escolha inválida");
                    Console.WriteLine("Escolha novamente");
                }
                else
                {
                    Console.WriteLine($"Profissional{profissionalEscolhido.NomeUsuario} Escolhido");
                    loop = false;
                    return profissionalEscolhido;
                }
            }
            return null;
        }
        private static void AvaliarServico(Profissional profissional)
        {
            Console.WriteLine("Coloque um valor de 1 a 5 estrela para esse serviço");
            int avalicao = int.Parse(Console.ReadLine());
            profissional.VezesAvaliado = +1;
            profissional.Estrelas = profissional.Estrelas + avalicao / profissional.VezesAvaliado;
        }
    }
}
