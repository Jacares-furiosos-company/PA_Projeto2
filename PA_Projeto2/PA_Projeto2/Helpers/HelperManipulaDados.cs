using PA_Projeto2.Objetos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PA_Projeto2.Helpers
{
    class HelperManipulaDados
    {
        public static string nomeUsuario;

        public static void NomeUsuario (string nome)
        {
            nomeUsuario = nome;
        }

        public static Usuario BuscaUsuario(string nomeUsuario)
        {
           foreach(var item in Program.dadosUsuarios.Usuarios)
            {
                if(item.NomeUsuario == nomeUsuario)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool VerificaUsuario(IEnumerable<Usuario> dadosusuarios ,string nomeUsuario, string senha)
        {
            var verificao = dadosusuarios.FirstOrDefault(x => x.NomeUsuario == nomeUsuario);
            if(verificao != null)
            {
                if(verificao.Senha == senha)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }
        public static bool VerificaUsuario(IEnumerable<Usuario> dadosusuarios, string nomeUsuario)
        {
            var verificao = dadosusuarios.FirstOrDefault(x => x.NomeUsuario == nomeUsuario);
            if (verificao != null)
            {
                return true;           
            }
            else
            {
                return false;
            }
        }
        public static int IncrementarID(IEnumerable<Usuario> dadosusuarios)
        {
            var usuario = dadosusuarios.OrderByDescending(x => x.IdUsuario).FirstOrDefault();
            if (usuario == null)
            {
                return 0;
            }
            else
            {
                return usuario.IdUsuario++;
            }

        }
        public static int verificaTipo(IEnumerable<Usuario> dadosusuarios, string nomeUsuario)
        {
            var usuario = dadosusuarios.FirstOrDefault(x => x.NomeUsuario == nomeUsuario);

            return usuario.TipoConta;
        }

    }
}
