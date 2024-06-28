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
                //Console.WriteLine("Você já possui um cadastro?");
                //bool cadastro= bool.Parse( Console.ReadLine()); 

                //if(cadastro == true)
                //{
                //    Console.WriteLine("Qaul é o seu CPF?");
                //}
            }
        }
    }


}
