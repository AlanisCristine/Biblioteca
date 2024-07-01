﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : Documento
    { 
        private int NumeroEdicao;
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public int anoPublicacao { get; set; }
        public Revista(string titulo, string autor, int anopubli)
        {
            Titulo = titulo;
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
