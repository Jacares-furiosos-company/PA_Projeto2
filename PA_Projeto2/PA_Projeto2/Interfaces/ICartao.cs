using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Interfaces
{
    interface ICartao
    {
        public string CartaoDeCredito
        { get; set; }
        int Cvv
        { get; set; }
        int DataValidade
        { get; set;}

        public void PagamentoCartao();

        public void ValidarCartao();

        public void CancelarCompra();

    }
}
