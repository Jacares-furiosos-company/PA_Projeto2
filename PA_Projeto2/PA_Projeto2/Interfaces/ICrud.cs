using PA_Projeto2.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2
{
    interface ICrud
    {
        public void AdicionarUsuario(Usuario usuario);

        public void RemoverUsuario(Usuario usuario);

        public void AtualizarUsuario(Usuario usuario);
    }
}
