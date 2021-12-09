using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        public Endereco Id_Endereco { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

    }
}
