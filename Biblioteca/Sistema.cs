using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sistema
    {
        public void IniciarSistema()
        {

            Console.WriteLine("Olá, você entrou no sistema da nossa Biblioteca Pública de Sabará!!!");
            Console.WriteLine("Para iniciar, qual das opções abaixo você deseja realizar?");
            Console.WriteLine("1- Emprestimo");
            Console.WriteLine("2- Devolução");
            Console.WriteLine("3- Doação de Livros");
            Console.WriteLine("0- Sair do sistema");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                
                Biblioteca b = new Biblioteca();
                
                Usuario usu = b.PossuiCadastro();
                //if(usu == null)
                //{
                    
                //    usu = new Usuario();
                //    b.AdicionarUsuarioBanco(usu.Cadastrar());
                   
                //}
                Console.WriteLine("Voce deseja editar algum dado?");
                Console.WriteLine("1 - Sim, desejo.");
                Console.WriteLine("2 - Não, obrigado(a)");
                int editardad = int.Parse(Console.ReadLine());
                if(editardad == 1)
                {
                    usu.EditarDados();
                }
                else if(editardad == 2)
                {
                    Console.WriteLine("Então vamos continuar com a sua escolha de livro :)");
                }

                
                int escolha2 = 0;
                Console.WriteLine("Você deseja realizar o empréstimo de um livro ou de uma revista?");
                Console.WriteLine("1- Livro");
                Console.WriteLine("2- Revista");

                escolha2 = int.Parse(Console.ReadLine());

                if(escolha2 == 1)
                {
                    b.SepararLivroporgenero();
                    Console.WriteLine("Livros Disponíveis");
                    //b.ListarLivros();
                    b.EscolherLivro(usu);
                }
                else if (escolha2 == 2)
                {
                    b.SepararRevistaporgenero();
                    Console.WriteLine("Revistas Disponíveis");
                    //b.ListarRevistas();
                    b.EscolherRevista(usu);
                }
                else
                {
                    Console.WriteLine("Escolha uma opção válida.");
                }
            }
            else if (escolha == 0)
            {

            }
        }
    }


}
