using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Profissional : Usuario
    {
        string tipoProfissao;

        public Profissional(int idUsuario, int estrelas, string senha, string nomeUsuario, int tipoConta, string contaBancaria, string tipoProfissao) : 
            base(idUsuario, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.tipoProfissao = tipoProfissao; 
        }

        public string Descricao { get => tipoProfissao; set => tipoProfissao = value; }
    }
}
