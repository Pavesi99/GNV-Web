using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Bairro
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cidade { get; set; }
        public string Nome { get; set; }
    }
}
