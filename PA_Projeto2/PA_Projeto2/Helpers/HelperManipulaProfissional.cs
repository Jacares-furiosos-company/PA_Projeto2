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
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("╔═════════════════ OPÇÕES DE ESPECIALIDADES ════════════════╗");
            Console.WriteLine("║ DIGITE 1 PARA MECÂNICO                                    ║");
            Console.WriteLine("║ DIGITE 2 PARA ENCANADOR                                   ║");
            Console.WriteLine("║ DIGITE 3 PARA ELETRICISTA                                 ║");
            Console.WriteLine("║ DIGITE 4 PARA MARCENEIRO                                  ║");
            Console.WriteLine("║ DIGITE 5 PARA PEDREIRO DE ACABAMENTO                      ║");
            Console.WriteLine("║ DIGITE 6 PARA SAIR                                        ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ATENÇÃO SÓ PODE ESCOLHER UMA ESPECIALIDADE !!!");
            Console.ForegroundColor = ConsoleColor.White;

            while (loop == true)
            {
                try
                {

                    var key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.D1 | key.Key == ConsoleKey.NumPad1)
                    {
                        especialidade.Add(1, "Mecânico");
                        Console.WriteLine("Especialidade Mecânico Foi Adicionado.");
                    }
                    else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                    {
                        especialidade.Add(2, "Encanador");
                        Console.WriteLine("Especialidade Encanador Foi Adicionado.");
                    }
                    else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                    {
                        especialidade.Add(3, "Eletricista");
                        Console.WriteLine("Especialidade Eletricista Foi Adicionado.");
                    }
                    else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                    {
                        especialidade.Add(4, "Marceneiro");
                        Console.WriteLine("Especialidade Marceneiro Foi Adicionado.");
                    }
                    else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
                    {
                        especialidade.Add(5, "Pedreiro de acabamento");
                        Console.WriteLine("Especialidade Pedreiro de acabamento Foi Adicionado.");
                    }
                    else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
                    {
                        loop = false;
                    }else
                    {
                        Console.WriteLine("Opção invalida, Tente Novamente !");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opção invalida, Tente Novamente !");
                }
               
            }
            return especialidade;
        }
    }
}
