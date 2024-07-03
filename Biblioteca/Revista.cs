using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : Documento
    { 
        private int NumeroEdicao;
        
        public string Autor { get; set; }

        public int anoPublicacao { get; set; }
        public Revista(int id, string titulo, bool disp, DateTime datadevolucao, Categoria cat, int classi, string autor, int anopubli)
             : base(id, titulo, disp, datadevolucao, cat, classi)
        {
            Autor = autor;
            anoPublicacao = anopubli;
        }
        public void ExibirRevista()
        {
            Console.WriteLine("----------Menu inicial-----------");
            Console.WriteLine($"ISBN: {NumeroEdicao}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Idade: {anoPublicacao}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
