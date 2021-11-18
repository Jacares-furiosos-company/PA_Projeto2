using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Cliente : Usuario
    {

        Cartao cartaoDeCredito;
        string endereco;

        public Cliente(int idUsuario,int vezesAvaliado, int estrelas, string senha, string nomeUsuario, int tipoConta, string contaBancaria, Cartao cartaoDeCredito, string endereco) :
             base(idUsuario, vezesAvaliado, estrelas, senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.cartaoDeCredito = cartaoDeCredito;
            this.endereco = endereco;
        }

        public Cartao CartaoDeCredito { get => cartaoDeCredito; set => cartaoDeCredito = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
