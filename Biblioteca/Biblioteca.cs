using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        Categoria Terror = new Categoria(1, "Terror");
        Categoria Romance = new Categoria(2, "Romance");
        Categoria Suspense = new Categoria(3, "Suspense");
        Categoria Fantasia = new Categoria(4, "Fantasia");
        Categoria Infantil = new Categoria(5, "Infantil");
        Categoria Moda = new Categoria(6, "Moda");
        Categoria Culinaria = new Categoria(7, "Culinaria");

        List<Emprestimo> Emprestimo;
        List<Usuario> Usuarios = new List<Usuario>() {
            new Usuario(1,"Perola", "perola@gamil.com","123456",10),
            new Usuario(2,"Isadora", "isadora@gamil.com","1237456",20),
            new Usuario(3,"Alanis", "alanis@gamil.com","1234586",20)
        };
        public List<Livro> Livros { get; set; }
        public List<Revista> Revistas { get; set; }
        public Biblioteca()
        {
            Livros = new List<Livro>();
            Revistas = new List<Revista>();
            InicializarBiblioteca();
        }
        public void InicializarBiblioteca()
        {
            Livros.Add(new Livro(1, "Ninguém vai te ouvir gritar", true, Terror, 16, "Mark Miler", 2007));
            Livros.Add(new Livro(2, "Cemitério dos Animais", true, Terror, 16, "Stephen King", 1983));
            Livros.Add(new Livro(3, "Frankenstein", true, Terror, 16, "Maria Shelley", 1818));
            Livros.Add(new Livro(4, "É assim que acaba", true, Romance, 18, "Collen Hoover", 2016));
            Livros.Add(new Livro(5, "Um amor de muitos verões", true, Romance, 12, "Ana faria", 2015));
            Livros.Add(new Livro(6, "Orgulho e preconceito", true, Romance, 10, "Jane Austen", 1813));
            Livros.Add(new Livro(7, "Um de nós está mentindo", true, Suspense, 16, "Karen M. MCmanus", 2019));
            Livros.Add(new Livro(8, "Obsessão fatal", true, Suspense, 14, "Gary Braver", 2015));
            Livros.Add(new Livro(9, "A garota do penhasco", true, Suspense, 10, "Lucinda Riley", 1999));
            Livros.Add(new Livro(10, "A menina bonita do laço de fita", true, Infantil, 0, "Karen M. MCmanus", 2005));
            Livros.Add(new Livro(11, "O menino maluquinho", true, Infantil, 0, "Ziraldo", 1990));
            Livros.Add(new Livro(12, "Diário de um banana", true, Infantil, 0, "Jeff Kinney", 2010));
            Livros.Add(new Livro(13, "Alice no país das maravilhas", true, Fantasia, 0, "Lewis Carroll", 1865));
            Livros.Add(new Livro(14, "O hobbit", true, Fantasia, 3, "John Ronald", 1996));
            Livros.Add(new Livro(15, "Sombra e osso", true, Fantasia, 10, "Leigh Bardugo", 2012));
            Revistas.Add(new Revista(1, "Moda em Paris", true, Moda, 0, "Vogue", 1865));
            Revistas.Add(new Revista(5, "Brisa", true, Moda, 0, "Moda Brasil", 1865));
            Revistas.Add(new Revista(2, "Chico Bento no Shopping", true, Infantil, 0, "Maurício de Souza", 1996));
            Revistas.Add(new Revista(3, "Turma da Mônica", true, Infantil, 0, "Maurício de Souza", 2000));
            Revistas.Add(new Revista(4, "Paola Carosella", true, Culinaria, 0, "MasterChef", 2018));
            Revistas.Add(new Revista(6, "Receitas Fáceis e Rápidas", true, Culinaria, 0, "Delícias da Cozinha", 2018));
        }



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

        Usuario usu = new Usuario();
        public Usuario PossuiCadastro()
        {
            Console.WriteLine("Você já possui um cadastro?");
            Console.WriteLine("1 - Sim, possuo e desejo entrar.");
            Console.WriteLine("2 - Não possuo e desejo Criar.");

            int cadastro = int.Parse(Console.ReadLine());

            if (cadastro == 1)
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
            else if (cadastro == 2)
            {
                usu.Cadastrar();
            }

            return null;
        }
        public void EscolherRevista(Usuario u)
        {
            Console.WriteLine("Qual é o ID da revista você deseja escolher?");
            int escolharevista = int.Parse(Console.ReadLine());
            Revista rev = EscolherRevistaporId(escolharevista);

            if (rev.getClassificacao() > u.Idade)
            {
                Console.WriteLine("Infelizmente esta revista não é indicada para a sua idade. Que tal escolher outra?");
                EscolherRevista(u);
            }
            else
            {
                Console.WriteLine($"{rev.Titulo} Escolhida com sucesso!");
            }
        }

        public void EscolherLivro(Usuario u)
        {

            Console.WriteLine("Qual é o ID do livro você deseja escolher?");
            int escolhalivro = int.Parse(Console.ReadLine());
            Livro liv = EscolherLivroporId(escolhalivro);


            if (liv.getClassificacao() > u.Idade)
            {
                Console.WriteLine("Infelizmente este livro não é indicado para a sua idade. Que tal escolher outro?");
                ListarLivros();
                EscolherLivro(u);
            }
            else
            {
                Console.WriteLine($"{liv.Titulo} Escolhida com sucesso!");
            }


        }

        public Livro EscolherLivroporId(int id)
        {

            foreach (Livro l in Livros)
            {
                if (id == l.id)
                {
                    return l;
                }
            }
            return null;
        }
        public Revista EscolherRevistaporId(int id)
        {
            foreach (Revista r in Revistas)
            {
                if (id == r.id)
                {
                    return r;
                }
            }
            return null;
        }
        public void SepararLivroporgenero()
        {
            Console.WriteLine("Você deseja escolher um gênero específico ou ver todos os livros disponíveis?");
            Console.WriteLine("1 - Escolher um gênero específico");
            Console.WriteLine("2 - Ver todos os livros");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Qual dos gêneros abaixo?");
                Console.WriteLine(" 1 - Terror");
                Console.WriteLine(" 2 - Roamance");
                Console.WriteLine(" 3 - Fantasia");
                Console.WriteLine(" 4 - Suspense");
                Console.WriteLine(" 5 - Infantil");
                int escolha2 = int.Parse(Console.ReadLine());


                foreach (Livro l in Livros)
                {
                    if (l.Categoria.Id == escolha2)
                    {
                        Console.WriteLine($"-----Livros de {l.Categoria.Genero}-----");
                        l.ExibirLivro();
                    }
                }

            }
            else if (escolha == 2)
            {
                ListarLivros();
            }
            else
            {
                Console.WriteLine("Escolha uma opção válida!!");
            }

        }

        public void SepararRevistaporgenero()
        {
            Console.WriteLine("Você deseja escolher um gênero específico ou ver todos os livros disponíveis?");
            Console.WriteLine("1 - Escolher um gênero específico");
            Console.WriteLine("2 - Ver todos os livros");
            int escolha = int.Parse(Console.ReadLine());


            if (escolha == 1)
            {
                Console.WriteLine("Qual dos gêneros abaixo?");
                Console.WriteLine(" 5 - Infantil");
                Console.WriteLine(" 6 - Moda");
                Console.WriteLine(" 7 - Culinária");

                int escolha2 = int.Parse(Console.ReadLine());

                foreach (Revista r in Revistas)
                {
                    if (r.Categoria.Id == escolha2)
                    {
                        Console.WriteLine($"-----Livros de {r.Categoria.Genero}-----");
                        r.ExibirRevista();
                    }
                }
            }
        }
    }
}
