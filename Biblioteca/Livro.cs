using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public class Livro : Documento
    {
        private string ISBN;
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public int anoPublicacao { get; set; }

        public Livro(string titulo, string autor, int anopubli)
        {
            Titulo = titulo;
            Autor = autor;
            anoPublicacao = anopubli;
        }
        public void ExibirLivro()
        {
            Console.WriteLine("----------Menu inicial-----------");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Idade: {anoPublicacao}");
            Console.WriteLine("-----------------------------------");
        }

       
    }

}
