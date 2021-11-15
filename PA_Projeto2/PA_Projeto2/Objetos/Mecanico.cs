using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Mecanico : Usuario
    {
        string descricao;

        public Mecanico(int idUsuario, int estrelas, int senha, string nomeUsuario, string tipoConta, string contaBancaria, string descricao) : 
            base(idUsuario, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.descricao = descricao;
        }

        public string Descricao { get => descricao; set => descricao = value; }
    }
}
