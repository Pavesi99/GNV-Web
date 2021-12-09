using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Tecido
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
