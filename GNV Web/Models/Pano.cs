using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class Pano
    {
        int _id;
        string _nome;
        int _remessa;
        int _quantidade;
        DateTime _dataEntrega;
        DateTime _dataColeta;

        public Pano()
        {

        }

        public Pano(int id, string nome, int remessa, int quantidade, DateTime dataEntrega, DateTime dataColeta)
        {
            this._id = id;
            this._nome = nome;
            this._remessa = remessa;
            this._quantidade = quantidade;
            this._dataEntrega = dataEntrega;
            this._dataColeta = dataColeta;
        }
        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Remessa { get => _remessa; set => _remessa = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public DateTime DataEntrega { get => _dataEntrega; set => _dataEntrega = value; }
        public DateTime DataColeta { get => _dataColeta; set => _dataColeta = value; }
    }
}
