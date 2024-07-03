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
            new Usuario(1,"Perola", "perola@gamil.com","123456",20),
            new Usuario(2,"Isadora", "isadora@gamil.com","1237456",20),
            new Usuario(3,"Alanis", "alanis@gamil.com","1234586",20)
        };
        List<Livro> Livros = new List<Livro>() {
           // Terror
            new Livro(1,"Ninguém vai te ouvir gritar", true, "terror", 16, "Mark Miler",2007),
            new Livro(2, "Cemitério dos Animais", "Stephen King",1983),
            new Livro(3, "Frankenstein", "Maria Shelley",1818),
            //Romance 
            new Livro(4, "É assim que acaba", "Collen Hoover",2016),
            new Livro(5, "Um amor de muitos verões", "Ana faria",2015),
            new Livro(6, "Orgulho e preconceito", "Jane Austen",1813),
            // Suspense
             new Livro(7, "Um de nós está mentindo", "Karen M. MCmanus",2019),
            new Livro(8, "Obsessão fatal", "Gary Braver",2015),
            new Livro(9, "A garota do penhasco", "Lucinda Riley",1999),
             // Infantil
             new Livro(10,"A menina bonita do laço de fita", "Karen M. MCmanus",2005),
            new Livro(11,"O menino maluquinho", "Ziraldo",1990),
            new Livro(12,"Diário de um banana", "Jeff Kinney",2010),
             // Fantasia
             new Livro(13,"Alice no país das maravilhas", "Lewis Carroll",1865),
            new Livro(14,"O hobbit", "John Ronald",1996),
            new Livro(15,"Sombra e osso", "Leigh Bardugo",2012),
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
        public void ListarLivros()
        {
            foreach (Livro li in Livros)
            {
                li.ExibirLivro();
            }
        }

        public void ListarRevistas()
        {
            foreach (Revista re in Revistas)
            {
                re.ExibirRevista();
            }
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
