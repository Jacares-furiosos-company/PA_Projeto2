using System;
using System.Collections.Generic;
using System.Text;
using PA_Projeto2.Helpers;
using PA_Projeto2.Objetos;

namespace PA_Projeto2
{
    class FluxoLogin
    {
        public void PedirLogin()
        {
            Console.WriteLine("1:Fazer Login");
            Console.WriteLine("2:Fazer Cadastro");
            int escolha = int.Parse(Console.ReadLine());
            if(escolha == 1)
            {
                RealizarLogin();
            }
            else if(escolha == 2)
            {
                RealizarCadastro();
            }
            
        }
        public void RealizarLogin() 
        {
            while (true)
            {
                Console.WriteLine("Informe seu usuario");
                string usuario = Console.ReadLine();
                Console.WriteLine("Informe sua senha");
                string senha = Console.ReadLine();

                bool verificao = HelperManipulaDados.VerificaUsuario(Program.dadosUsuarios.Usuarios, usuario, senha);

                if (verificao)
                {
                    Console.WriteLine("Login Realizado");
                    int tipoConta = HelperManipulaDados.verificaTipo(Program.dadosUsuarios.Usuarios, usuario);                  
                    if (tipoConta == 1)
                    {
                        FluxoCliente.FluxoPrincipal();
                    }
                    else if (tipoConta == 2)
                    {
                        FluxoProfissional.FluxoPrincipal();
                    }
                }
                else
                {
                    Console.WriteLine("Usuario ou senha incorretos");
                    Console.WriteLine("Escolha Sua Opção");
                    Console.WriteLine("Apertar qualquer tecla para tentar o login novamente");
                    Console.WriteLine("1:Realizar Cadastro");
                    int escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        RealizarCadastro();
                    }
                }
            }

        }
        public void RealizarCadastro()
        {      
            while(true)
            {
                Console.WriteLine("Escolha seu nome de usuário");
                string nomeUsuario = Console.ReadLine();
                bool verificaUsuario = HelperManipulaDados.VerificaUsuario(Program.dadosUsuarios.Usuarios, nomeUsuario);
                int id = HelperManipulaDados.VerificaID(Program.dadosUsuarios.Usuarios);
                if (!verificaUsuario)
                {
                    Console.WriteLine("Escolha sua senha");
                    string senha = Console.ReadLine();
                    Console.WriteLine("Digite usa conta bancária");
                    string contaBancaria = Console.ReadLine();
                    while(true)
                    {
                        Console.WriteLine("Escolha o tipo da sua conta");
                        Console.WriteLine("1:Cliente");
                        Console.WriteLine("2:Profissional");
                        int tipoConta = int.Parse(Console.ReadLine());

                        if (tipoConta == 1)
                        {
                            Console.WriteLine("Digite seu cartão");
                            string cartaoCredito = Console.ReadLine();
                            Console.WriteLine("Digite seu endereço");
                            string endereco = Console.ReadLine();

                            Cliente cliente = new Cliente(id, 5, senha, nomeUsuario, tipoConta, contaBancaria, cartaoCredito, endereco);
                            Program.dadosUsuarios.AdicionarUsuario(cliente);
                        }
                        else if (tipoConta == 2)
                        {
                            Console.WriteLine("Que tipo de Profissional você é?");
                            Dictionary<int, string> especialidades = EscolherEspecialidade();

                            Profissional profissional = new Profissional(id, 5, senha, nomeUsuario, tipoConta, contaBancaria, especialidades);
                            Program.dadosUsuarios.AdicionarUsuario(profissional);
                        }
                        Console.WriteLine("Cadastro realizado");
                        Console.WriteLine("Indo para a tela de login");
                        RealizarLogin();

                    }
                }
                else
                {
                    Console.WriteLine("Nome de Usuário já registrado");
                }
            }
        }
        public Dictionary<int, string> EscolherEspecialidade()
        {
            bool loop = true;
            Dictionary<int ,string> especialidade = new Dictionary<int, string>();
            while (loop == true)
            {
                Console.WriteLine("Aperte Qualquer Tecla para sair");
                Console.WriteLine("Escolha Suas Especialidades");
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
