using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo
    {
        private int Id;
        private List<Livro> Livro;
        private List<Revista> Revista;
        private List<Usuario> Usuario;
        private DateTime DataEmprestimo;
        private DateTime DataPrevistaDevolucao;
    }

}
