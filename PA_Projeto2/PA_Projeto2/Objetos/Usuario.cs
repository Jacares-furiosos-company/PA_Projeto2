using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    abstract class Usuario 
    {
        int idUsuario;
        string nomeUsuario;
        string senha;
        int tipoConta;
        string contaBancaria;
        int estrelas;
 
        public Usuario(int idUsuario, int estrelas, string senha, string nomeUsuario, int tipoConta, string contaBancaria)
        {
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
            this.senha = senha;
            this.tipoConta = tipoConta;
            this.contaBancaria = contaBancaria;
            this.estrelas = estrelas;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public int TipoConta { get => tipoConta; set => tipoConta = value; }
        public string ContaBancaria { get => contaBancaria; set => contaBancaria = value; }
        public int Estrelas { get => estrelas; set => estrelas = value; }
    }
}
