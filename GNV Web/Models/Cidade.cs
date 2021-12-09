using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Cidade
    {
        int _id;
        string _nome;

        public Cidade()
        {

        }

        public Cidade(int id, string nome)
        {
            _id = id;
            _nome = nome;
        }

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }

        //[Key]
        //public int Id { get; set; }
        //public string Nome { get; set; }
    }
}
