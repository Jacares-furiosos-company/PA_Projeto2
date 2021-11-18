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
                        FluxoProfissional.FluxoPrincipal(usuario);
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
                int id = HelperManipulaDados.IncrementarID(Program.dadosUsuarios.Usuarios);
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
                            Console.WriteLine("Digite o numero do seu cartão");
                            string numeroCartao = Console.ReadLine();

                            Console.WriteLine("Digite seu cvv");
                            int cvv = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a data de validade do cartão");
                            int dataValidade = int.Parse(Console.ReadLine());
                            Cartao cartaoCredito = new Cartao(numeroCartao, cvv, dataValidade);

                            Console.WriteLine("Digite seu endereço");
                            string endereco = Console.ReadLine();

                            Cliente cliente = new Cliente(id, 5, 1,senha, nomeUsuario, tipoConta, contaBancaria, cartaoCredito, endereco);
                            Program.dadosUsuarios.AdicionarUsuario(cliente);
                        }
                        else if (tipoConta == 2)
                        {
                            Console.WriteLine("Que tipo de Profissional você é?");
                            Dictionary<int, string> especialidades = HelperManipulaProfissional.EscolherEspecialidade();

                            Profissional profissional = new Profissional(id, 5, 1, senha, nomeUsuario, tipoConta, contaBancaria, especialidades);
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
    }
}
