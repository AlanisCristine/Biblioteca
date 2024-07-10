using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Doacao
    {
        public string doacao { get; set; }
        public int cpf { get; set; }

        public void RealizarDoacao(String DOACAO , int CPF)
        {
            doacao = DOACAO;
            cpf = CPF;
        }

       
    }
}
