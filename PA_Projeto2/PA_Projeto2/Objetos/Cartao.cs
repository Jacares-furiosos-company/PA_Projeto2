using System;
using System.Collections.Generic;
using System.Text;
using PA_Projeto2.Interfaces;

namespace PA_Projeto2
{
    class Cartao : ICartao
    {
        string cartaoDeCredito;
        int cvv;
        int dataValidade;
        public Cartao(string cartaoDeCredito, int cvv, int dataValidade)
        {
            this.cartaoDeCredito = cartaoDeCredito;
            this.cvv = cvv;
            this.dataValidade = dataValidade;
        }
        public void CancelarCompra()
        {
            throw new NotImplementedException();
        }

        public void PagamentoCartao()
        {
            throw new NotImplementedException();
        }

        public void ValidarCartao()
        {
            throw new NotImplementedException();
        }
        public string CartaoDeCredito { get => cartaoDeCredito; set => throw new NotImplementedException(); }
        public int Cvv { get => cvv; set => throw new NotImplementedException(); }
        public int DataValidade { get => dataValidade; set => throw new NotImplementedException(); }
    }
}
