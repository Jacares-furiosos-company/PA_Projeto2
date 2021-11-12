using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Cliente : Usuario
    {

        int cartaoDeCredito;
        string endereco;

        public Cliente(int cartaoDeCredito, string endereco, int idUsuario, string nomeUsuario, int senha, string tipoConta, string contaBancaria, int estrelas) :
             base(idUsuario, nomeUsuario, senha, tipoConta, contaBancaria, estrelas)
        {
            this.cartaoDeCredito = cartaoDeCredito;
            this.endereco = endereco;
        }
    }
}
