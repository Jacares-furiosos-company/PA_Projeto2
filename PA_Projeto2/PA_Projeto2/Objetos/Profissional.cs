using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Projeto2.Objetos
{
    class Profissional : Usuario
    {
        Dictionary<int, string> especialidades;

        public Profissional(int idUsuario, int vezesAvaliado, int estrelas, string senha,
            string nomeUsuario, int tipoConta, string contaBancaria,
            Dictionary<int, string> especialidades) : 

            base(idUsuario, estrelas,vezesAvaliado ,senha, nomeUsuario, tipoConta, contaBancaria)
        {
            this.especialidades = especialidades; 
        }

        public Dictionary<int, string> Especialidades { get => especialidades; set => especialidades = value; }
    }
}
