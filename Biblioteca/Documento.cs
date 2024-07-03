using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Documento
    {
        protected int id;
        protected string Titulo;
        private bool Disponivel;
        private DateTime DataDevolucao;
        private Categoria Categoria;
        private int Classificacao;
         
        public Documento(int id, string titulo, bool disponivel, Categoria categoria, int classificacao)
        {
            this.id = id;
            Titulo = titulo;
            Disponivel = disponivel;
            DataDevolucao = DateTime.Now.AddDays(7);
            Categoria = categoria;
            Classificacao = classificacao;
        }
    }
}
