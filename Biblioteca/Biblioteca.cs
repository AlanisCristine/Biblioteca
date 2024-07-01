using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        List<Emprestimo> Emprestimo;
        List<Usuario> Usuarios = new List<Usuario>() {
            new Usuario(1,"Perola", "perola@gamil.com",123456,20),
            new Usuario(2,"Isadora", "isadora@gamil.com",1237456,20),
            new Usuario(3,"Alanis", "alanis@gamil.com",1234586,20)
        };
        List<Livro> Livros = new List<Livro>() {
           // Terror
            new Livro("Ninguém vai te ouvir gritar", "Mark Miler",2007),
            new Livro("Cemitério dos Animais", "Stephen King",1983),
            new Livro("Frankenstein", "Maria Shelley",1818),
            //Romance
            new Livro("É assim que acaba", "Collen Hoover",2016),
            new Livro("Um amor de muitos verões", "Ana faria",2015),
            new Livro("Orgulho e preconceito", "Jane Austen",1813),
            // Suspense
             new Livro("Um de nós está mentindo", "Karen M. MCmanus",2019),
            new Livro("Obsessão fatal", "Gary Braver",2015),
            new Livro("A garota do penhasco", "Lucinda Riley",1999),
             // Infantil
             new Livro("A menina bonita do laço de fita", "Karen M. MCmanus",2005),
            new Livro("O menino maluquinho", "Ziraldo",1990),
            new Livro("Diário de um banana", "Jeff Kinney",2010),
             // Fantasia
             new Livro("Alice no país das maravilhas", "Lewis Carroll",1865),
            new Livro("O hobbit", "John Ronald",1996),
            new Livro("Sombra e osso", "Leigh Bardugo",2012),
        };

        List<Revista> Revistas = new List<Revista>()
       {
           new Revista("moda", "Vogue",1865),
            new Revista("Quadrinhos", "Maurício de Souza",1996),
            new Revista("Adulta", "PlayBoy",2000),
       };

        public void AdicionarUsuarioBanco(Usuario usu)
        {
            Usuarios.Add(usu);
            Console.WriteLine("Usuário adicionado sucesso!!!");
        }

        public Usuario PossuiCadastro()
        {
            Console.WriteLine("Você já possui um cadastro?");
            bool cadastro = bool.Parse(Console.ReadLine());

            if (cadastro == true)
            {
                Console.WriteLine("Informe seu CPF:");
                string cpf = Console.ReadLine();

                foreach (Usuario usu in Usuarios)
                {
                    if (cpf == usu.getCPF().ToString())
                    {
                        usu.ExibirDados();
                        return usu;
                    }

                }

            }

            return null;
        }
    }
}
