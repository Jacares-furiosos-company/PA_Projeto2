using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Cliente : Usuario
    {

        int cartaoDeCredito;
        string endereco;

        public Cliente(int idUsuario, int estrelas, int senha, string nomeUsuario, string tipoConta, string contaBancaria, int cartaoDeCredito, string endereco) :
             base(idUsuario, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.cartaoDeCredito = cartaoDeCredito;
            this.endereco = endereco;
        }

        public int CartaoDeCredito { get => cartaoDeCredito; set => cartaoDeCredito = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
