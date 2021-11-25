using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Interfaces
{
    interface ICartao
    {
        public string NumeroCartao
        { get; set; }
        int Cvv
        { get; set; }
        string DataValidade
        { get; set;}

        public void PagamentoCartao();

        public Boolean ValidarCartao();

        public Boolean CancelarCompra();

    }
}
