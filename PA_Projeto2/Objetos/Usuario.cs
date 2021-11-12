using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Usuario 
    {
        int idUsuario;
        string nomeUsuario;
        int senha;
        string tipoConta;
        string ContaBancaria;
        int estrelas;

        public Usuario(int idUsuario, string nomeUsuario, int senha, string tipoConta, string contaBancaria, int estrelas)
        {
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
            this.senha = senha;
            this.tipoConta = tipoConta;
            ContaBancaria = contaBancaria;
            this.estrelas = estrelas;
        }
    }
}
