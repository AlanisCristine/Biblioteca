using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Documento
    {
        public int id;
        public string Titulo;
        private bool Disponivel;
        private DateTime DataDevolucao;
        private Categoria Categoria;
        public int Classificacao;

       

        List<Categoria> Categorias = new List<Categoria>
        {
            new Categoria (1, "Terror"),
            new Categoria (2, "Romance"),
            new Categoria (3, "Suspense"),
            new Categoria (4, "Fantasia"),
            new Categoria (5, "Infantil"),
        };

        public Documento(int id, string titulo, bool disponivel, Categoria categoria, int classificacao)
        {
            this.id = id;
            Titulo = titulo;
            Disponivel = disponivel;
            DataDevolucao = DateTime.Now.AddDays(7);
            Categoria = categoria;
            Classificacao = classificacao;
        }
        public int getClassificacao()
        {
            return Classificacao;
        }
    }
}
