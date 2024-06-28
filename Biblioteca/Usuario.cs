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
        public int CPF;
        private int Idade;

        public void ExibirDados()
        {
            Console.WriteLine("----------Menu inicial-----------");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine("-----------------------------------");
        }
        public void PossuiCadastro()
        {
            Console.WriteLine("Você já possui um cadastro?");
            bool cadastro = bool.Parse(Console.ReadLine());

            if (cadastro==true) 
            {
                Console.WriteLine("Informe seu CPF:");
                int cpf  = int.Parse(Console.ReadLine());

                if (cpf == CPF)
                {
                    Console.WriteLine("CPF Válido");
                }
                else
                {
                    Console.WriteLine("Digite um CPF válido");
                }
            }
        }
    }


}
