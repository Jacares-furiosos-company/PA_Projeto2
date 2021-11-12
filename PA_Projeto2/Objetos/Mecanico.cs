using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Mecanico : Usuario
    {
        string descricao;

        public Mecanico(string descricao, int idUsuario, string nomeUsuario, int senha, string tipoConta, string contaBancaria, int estrelas): 
            base(idUsuario, nomeUsuario, senha, tipoConta, contaBancaria, estrelas)
        {
            this.descricao = descricao;
        }
    }
}
