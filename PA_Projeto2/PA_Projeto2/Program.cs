using PA_Projeto2.Objetos;
using System;
using System.Linq;

namespace PA_Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosUsuarios bancoDados = new DadosUsuarios();
            Console.WriteLine("Hello World!");
            Cliente cliente = new Cliente(1, 1, 1, "1", "1", "1", 1, "1");
            Cliente cliente2 = new Cliente(1, 1, 1, "2", "1", "1", 1, "1");
            Cliente cliente3 = new Cliente(1, 1, 1, "3", "1", "1", 1, "1");
            bancoDados.AdicionarUsuario(cliente);
            bancoDados.AdicionarUsuario(cliente2);
            bancoDados.AdicionarUsuario(cliente3);

            var usuario = bancoDados.Usuarios.FirstOrDefault(x => x.NomeUsuario == "2");

            Console.WriteLine(usuario.NomeUsuario);

        }
    }
}
