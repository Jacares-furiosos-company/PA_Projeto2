using PA_Projeto2.Objetos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Helpers
{
    class HelperManipulaProfissional
    {
        public static List<Usuario> BuscaProfissionais()
        {
            var profissionais = Program.dadosUsuarios.Usuarios.FindAll(x => x.TipoConta == 2);
            return profissionais;
        }
        public static Profissional BuscaProfissional(string nomeUsuario, List<Usuario> profissionais)
        {
            foreach(Profissional profissional in profissionais)
            {
                if (profissional.NomeUsuario == nomeUsuario)
                {
                    return profissional;
                }
            }
            Console.WriteLine("Profissional não encontrado");
            return null;
        }
        public static Dictionary<int, string> EscolherEspecialidade()
        {
            bool loop = true;
            Dictionary<int, string> especialidade = new Dictionary<int, string>();
            while (loop == true)
            {
                Console.WriteLine("Aperte Qualquer Tecla para sair");
                Console.WriteLine("Escolha Suas Especialidade");
                Console.WriteLine("1:Mecânico");
                Console.WriteLine("2:Encanador");
                Console.WriteLine("3:Eletricista");
                Console.WriteLine("4:Marceneiro");
                Console.WriteLine("5:Pedreiro de acabamento");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    especialidade.Add(1, "Mecânico");
                }
                else if (escolha == 2)
                {
                    especialidade.Add(2, "Encanador");
                }
                else if (escolha == 3)
                {
                    especialidade.Add(3, "Eletricista");
                }
                else if (escolha == 4)
                {
                    especialidade.Add(4, "Marceneiro");
                }
                else if (escolha == 5)
                {
                    especialidade.Add(5, "Pedreiro de acabamento");
                }
                else
                {
                    loop = false;
                }
            }
            Console.WriteLine("Escolha De Suas Especialidades Finalizada");
            return especialidade;
        }
    }
}
