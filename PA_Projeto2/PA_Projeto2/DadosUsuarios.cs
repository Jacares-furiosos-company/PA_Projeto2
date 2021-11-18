using PA_Projeto2.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    class DadosUsuarios : ICrud
    {
        List<Usuario> usuarios;

        public DadosUsuarios()
        {
            usuarios = new List<Usuario>();
        }
        public void AdicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public  void RemoverUsuario(Usuario usuario)
        {
            if(usuarios.Contains(usuario))
            {
                usuarios.Remove(usuario);
            }
           
        }
        public void AtualizarUsuario(Usuario usuario)
        {
            if(usuarios.Contains(usuario))
            {
                //trocarDadosClientes
            }
        }
        public List<Usuario> Usuarios
        {
            get => usuarios;
        }

    }
}
