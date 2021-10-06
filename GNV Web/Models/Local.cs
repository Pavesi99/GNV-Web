using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Local
    {
        public Local(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
    }
}
