using System;
using System.Collections.Generic;
using System.Text;
using PA_Projeto2.Helpers;
using PA_Projeto2.Objetos;

namespace PA_Projeto2
{
    class FluxoLogin
    {
        public void Menu()
        {
            var menu = true;

            while (menu)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ISERVICE ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("╔═════════════════ MENU DE OPÇÕES ════════════════╗");
                Console.WriteLine("║ PARA INCIAR ESCOLHA UMA OPÇÃO                   ║");
                Console.WriteLine("║ DIGITE 1 PARA FAZER LOGIN                       ║");
                Console.WriteLine("║ DIGITE 2 PARA FAZER CADASTRO                    ║");
                Console.WriteLine("║ DIGITE 3 PARA SAIR                              ║");
                Console.WriteLine("╚═════════════════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.White;

                switch (Console.ReadLine())
                {
                    // ❌❌❌
                    case "1":
                        RealizarLogin();
                        break;

                    case "2":
                        RealizarCadastro();
                        break;

                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╔═════════════════ FIM ════════════════╗");
                        Console.WriteLine("║                                      ║");
                        Console.WriteLine("║               OBRIGADO !             ║");
                        Console.WriteLine("║                                      ║");
                        Console.WriteLine("║                                      ║");
                        Console.WriteLine("╚══════════════════════════════════════╝");
                        menu = false;
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                }
            }
        }
        public void RealizarLogin() 
        {
            int i = 0;

            while (true)
            {
                Console.Write("═══════════════════════════════════════════════════");
                Console.Write("\nInforme seu usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Informe sua senha: ");
                string senha = Console.ReadLine();
                Console.WriteLine("");

                bool verificao = HelperManipulaDados.VerificaUsuario(Program.dadosUsuarios.Usuarios, usuario, senha);

                if (verificao)
                {
                    Console.Write("═══════════════════════════════════════════════════");
                    Console.Write("\nLogin efetuado com Sucesso !\n");
                    int tipoConta = HelperManipulaDados.verificaTipo(Program.dadosUsuarios.Usuarios, usuario);                  
                    if (tipoConta == 1)
                    {
                        HelperManipulaDados.NomeUsuario(usuario);
                        FluxoCliente.FluxoPrincipal();                        
                    }
                    else if (tipoConta == 2)
                    {
                        FluxoProfissional.FluxoPrincipal(usuario);
                    }
                }
                else
                {
                    Console.WriteLine("Usuario ou senha incorretos");
                    Console.Write("Tecle Enter ou qual quer outra tecla para fazer login novamente :");
                    string digitado = Console.ReadLine();
                    i++;
                    if (i == 2)
                    {
                        Console.WriteLine("\n═══════════════════════════════════════════════════");
                        Console.WriteLine("Voce não tem cadastro ou Errou seu login mais de 2 vezes");
                        Console.WriteLine("Voce será direcionado para tela de Menu novamente, Tecle Enter");
                        string _ = Console.ReadLine();
                        Menu();
                    }
                }
            }

        }

        public void RealizarCadastro()
        {      
            while(true)
            {
                Console.Write("═══════════════════════════════════════════════════");
                Console.Write("\nEscolha seu nome de usuário: ");
                string nomeUsuario = Console.ReadLine();
                bool verificaUsuario = HelperManipulaDados.VerificaUsuario(Program.dadosUsuarios.Usuarios, nomeUsuario);
                int id = HelperManipulaDados.IncrementarID(Program.dadosUsuarios.Usuarios);
                if (!verificaUsuario)
                {
                    Console.Write("Escolha sua senha: ");
                    string senha = Console.ReadLine();
                    Console.Write("Digite sua chave Pix: ");
                    string contaBancaria = Console.ReadLine();

                    while(true)
                    {
                        try
                        {                        
                            Console.WriteLine("═══════════════════════════════════════════════════");
                            Console.WriteLine("Escolha o tipo da sua conta");
                            Console.WriteLine("Digite 1 para Cliente");
                            Console.WriteLine("Digite 2 para Profissional");
                            int tipoConta = int.Parse(Console.ReadLine());

                            if (tipoConta == 1)
                            {
                                Console.WriteLine("═══════════════════════════════════════════════════");
                                Console.Write("Digite o numero do seu cartão: ");
                                string numeroCartao = Console.ReadLine();

                                Console.Write("Digite seu cvv: ");
                                int cvv = int.Parse(Console.ReadLine());

                                Console.Write("Digite a data de validade do cartão: ");
                                string dataValidade = Console.ReadLine();
                                Cartao cartaoCredito = new Cartao();
                                cartaoCredito.Card(numeroCartao, cvv, dataValidade);

                                Console.Write("Digite seu endereço: ");
                                string endereco = Console.ReadLine();

                                Cliente cliente = new Cliente(id, 5, 1,senha, nomeUsuario, tipoConta, contaBancaria, cartaoCredito, endereco);
                                Program.dadosUsuarios.AdicionarUsuario(cliente);

                                Console.WriteLine("═══════════════════════════════════════════════════");
                                Console.WriteLine("Cadastro Realizado com Sucesso !");
                                Console.WriteLine("Digite Enter para realisar login");
                                string _ = Console.ReadLine();
                                RealizarLogin();
                            }
                            else if (tipoConta == 2)
                            {
                                Console.WriteLine("═══════════════════════════════════════════════════");
                                Console.WriteLine("Que tipo de Profissional você é ?\n");
                                Dictionary<int, string> especialidades = HelperManipulaProfissional.EscolherEspecialidade();

                                Profissional profissional = new Profissional(id, 5, 1, senha, nomeUsuario, tipoConta, contaBancaria, especialidades);
                                Program.dadosUsuarios.AdicionarUsuario(profissional);

                                Console.WriteLine("═══════════════════════════════════════════════════");
                                Console.WriteLine("Cadastro Realizado com Sucesso !");
                                Console.WriteLine("Digite Enter para realisar login");
                                string _ = Console.ReadLine();
                                RealizarLogin();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Opção invalida !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nome de Usuário já registrado");
                }
            }
        }
    }
}
