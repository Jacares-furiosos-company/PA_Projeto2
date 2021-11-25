using PA_Projeto2.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PA_Projeto2
{
    class Program
    {
        public static DadosUsuarios dadosUsuarios = new DadosUsuarios();
        static void Main(string[] args)
        {
            Dictionary<int, string> especialidade = new Dictionary<int, string>();
            especialidade.Add(4, "Marceneiro");
            especialidade.Add(1, "Mecânico");
            //Cliente cliente = new Cliente(1, 5, 1, "teste", "teste", 1, "teste", "teste1", "teste");
            Profissional profissional = new Profissional(1, 5, 1,"teste1", "teste1", 2, "", especialidade);
            Profissional profissional2 = new Profissional(2, 5, 1,"teste2", "teste1", 2, "", especialidade);
            Profissional profissional3 = new Profissional(3, 5, 1,"teste3", "teste1", 2, "", especialidade);
            dadosUsuarios.AdicionarUsuario(profissional);
            dadosUsuarios.AdicionarUsuario(profissional2);
            dadosUsuarios.AdicionarUsuario(profissional3);
            //dadosUsuarios.AdicionarUsuario(cliente);
            FluxoLogin login = new FluxoLogin();
            login.Menu();

        }
    }
}