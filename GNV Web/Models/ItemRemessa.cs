using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class ItemRemessa
    {
        [Key]
        public int Id { get; set; }
        public Pano Id_Pano { get; set; }
        public Remessa Id_Remessa { get; set; }
        public UnidadeMedida Id_UnidadeMedida { get; set; }
        public bool Localizacao_Atual { get; set; }
        public float Preco_Item { get; set; }
        public int Quantidade { get; set; }
        public DateTime Previsao_Coleta { get; set; }
        public DateTime Data_Coleta { get; set; }
    }
}
