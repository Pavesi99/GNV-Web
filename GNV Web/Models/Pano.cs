using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Pano
    {
        int _id;
        string _nome;
        Tecido _idTecido;
        CorEstampa _idCorEstampa;      
        float _precoPadrao;

        public Pano()
        {

        }

        public Pano(int id, Tecido idTecido, CorEstampa idCorEstampa ,string nome, float precoPadrao)
        {
            this.Id = id;
            this.IdTecido = idTecido;
            this.IdCorEstampa = idCorEstampa;
            this.Nome = nome;
            this.PrecoPadrao = precoPadrao;
           
        }
        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public Tecido IdTecido { get => _idTecido; set => _idTecido = value; }
        public CorEstampa IdCorEstampa { get => _idCorEstampa; set => _idCorEstampa = value; }
        public float PrecoPadrao { get => _precoPadrao; set => _precoPadrao = value; }       

    }
}
