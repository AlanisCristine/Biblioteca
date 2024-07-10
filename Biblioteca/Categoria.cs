using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Categoria
    {
        public string Genero;
        public int Id;

        public Categoria(int id, string gen)
        {
            Id = id;
            Genero = gen;
        }
    }
}
