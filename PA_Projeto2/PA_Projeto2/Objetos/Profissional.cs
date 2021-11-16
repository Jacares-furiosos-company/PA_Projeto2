using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Profissional : Usuario
    {
        string tipoProfissional;

        public Profissional(int idUsuario, int estrelas, string senha, string nomeUsuario, int tipoConta, string contaBancaria, string tipoProfissional) : 
            base(idUsuario, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.tipoProfissional = tipoProfissional; 
        }

        public string Descricao { get => tipoProfissional; set => tipoProfissional = value; }
    }
}
