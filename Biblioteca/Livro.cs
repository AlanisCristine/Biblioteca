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

        public string Autor { get; set; }

        public int anoPublicacao { get; set; }

        public Livro()
            : base(0,string.Empty,false, null, 0) 
        {
        
        }



        public Livro(int id, string titulo, bool disp, Categoria cat, int classi, string autor, int anopubli)
            : base(id, titulo, disp, cat, classi)
        {
            Autor = autor;
            anoPublicacao = anopubli;
        }

        public void ExibirLivro()
        {
            Console.WriteLine("----------Livro:-----------");
            Console.WriteLine($"ISBN: {id}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Idade: {anoPublicacao}");
            Console.WriteLine($"Classificação indicativa: {Classificacao}");
            Console.WriteLine($"Disponibilidade: {GetDisponivel()}");
            Console.WriteLine("-----------------------------------");
        }


    }

}
