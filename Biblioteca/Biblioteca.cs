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
