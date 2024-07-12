using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        private int id;
        private string Nome;
        private string Email;
        private string CPF;
        public int Idade;

        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string cPF, int idade)
        {
            this.id = id;
            Nome = nome;
            Email = email;
            CPF = cPF;
            Idade = idade;
        }

        public string getCPF() { return CPF; }
        public string getNome() { return Nome; }
        public void ExibirDados()
        {
            Console.WriteLine("----------Menu inicial-----------");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine("-----------------------------------");
        }
        
        public Usuario Cadastrar()
        {
            Console.WriteLine("Vamos começar o cadastro!");
            Console.WriteLine("Qual é o seu nome completo?");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual é o seu Email?");
            Email = Console.ReadLine();

            Console.WriteLine("Qual é o seu CPF?");
            CPF = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastro realizado com sucesso!");
            ExibirDados();
            
            return this;
        }

        public void EditarDados()
        {
            Console.WriteLine("----------Edição de Dados----------");
            Console.WriteLine("O que você deseja alterar?");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Email");
            Console.WriteLine("3 - Idade");
            Console.WriteLine("4 - CPF");
            int escolha = int.Parse(Console.ReadLine());
            
            if(escolha == 1)
            {
                Console.WriteLine("Qual é o novo nome?");
                Nome = Console.ReadLine();
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Qual é o novo Email?");
                Email = Console.ReadLine();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("Qual é a nova Idade?");
                Idade = int.Parse(Console.ReadLine());
            }
            else if (escolha == 4)
            {
                Console.WriteLine("Qual é o novo CPF?");
                CPF = Console.ReadLine();
            }
            ExibirDados();
        }
    }


}
