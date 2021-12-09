using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public Bairro Id_Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
        public string CEP { get; set; }



    }
}
