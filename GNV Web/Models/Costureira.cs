using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Costureira
    {
        [Key]
        public int Id { get; set; }
        public Empresa Id_Empresa { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }
    }
}
