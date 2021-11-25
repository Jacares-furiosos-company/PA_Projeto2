using PA_Projeto2.Objetos;
using PA_Projeto2.Helpers;
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
            var profissionais = HelperManipulaProfissional.BuscaProfissionais();
            var especialidadeEscolhida = escolherEspecialidade();
            var profissionaisTipo = mostraProfissionais(especialidadeEscolhida, profissionais);
            var profissionalEscolhido = escolhaDoProfissional(profissionaisTipo, especialidadeEscolhida);

            Pagamento.EscolherPagamento(profissionalEscolhido);
            avaliarServico(profissionalEscolhido);
        }
        private static int escolherEspecialidade()
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
        private static List<Profissional> mostraProfissionais(int escolha, List<Usuario> profissionais)
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


        private static Profissional escolhaDoProfissional(List<Profissional> profissionaisEncontrados, int especialidadeEscolhida)
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
        private static void avaliarServico(Profissional profissional)
        {
            try
            {
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine("Dê uma nota de 1 a 5 para o Atendimento !");
                int avalicao = int.Parse(Console.ReadLine());
                profissional.VezesAvaliado = +1;
                profissional.Estrelas = profissional.Estrelas + avalicao / profissional.VezesAvaliado;
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine("Obrigado, Pela Nota !");
                Console.WriteLine("Agora voce será Levado para Pagina Pincipal !");
                Console.WriteLine("Aperte Enter !");
                string _ = Console.ReadLine();
                Console.Clear();
                FluxoLogin fluxoLogin = new FluxoLogin();
                fluxoLogin.Menu();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção Invalida !");
            }

        }
    }
}
