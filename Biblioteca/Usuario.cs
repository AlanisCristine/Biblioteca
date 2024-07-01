using System;
using System.Collections.Generic;
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
        private int CPF;
        private int Idade;

        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, int cPF, int idade)
        {
            this.id = id;
            Nome = nome;
            Email = email;
            CPF = cPF;
            Idade = idade;
        }

        public int getCPF() { return CPF; }

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
            CPF = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a sua idade?");
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastro realizado com sucesso!");
            ExibirDados();
            
            return this;
        }


    }


}
