﻿using System;
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
        private bool Disponivel { get; set; }
        public DateTime DataDevolucao;
        public Categoria Categoria;
        public int Classificacao;

        public bool GetDisponivel()
        {
            return Disponivel;
        }
        public void SetDisponivel()
        {
            if(Disponivel == false)
            {
                Disponivel= true;
            }
            else
            {
                Disponivel = false;
            }
            
        }


        List<Categoria> Categorias = new List<Categoria>
        {
            new Categoria (1, "Terror"),
            new Categoria (2, "Romance"),
            new Categoria (3, "Suspense"),
            new Categoria (4, "Fantasia"),
            new Categoria (5, "Infantil"),
            new Categoria (6, "Moda"),
            new Categoria(7, "Culinária"),

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
