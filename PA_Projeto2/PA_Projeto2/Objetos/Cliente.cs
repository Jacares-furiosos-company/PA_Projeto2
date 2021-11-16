using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Cliente : Usuario
    {

        string cartaoDeCredito;
        string endereco;

        public Cliente(int idUsuario, int estrelas, string senha, string nomeUsuario, int tipoConta, string contaBancaria, string cartaoDeCredito, string endereco) :
             base(idUsuario, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.cartaoDeCredito = cartaoDeCredito;
            this.endereco = endereco;
        }

        public string CartaoDeCredito { get => cartaoDeCredito; set => cartaoDeCredito = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
