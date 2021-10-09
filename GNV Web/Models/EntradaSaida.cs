using GNV_Web.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Models
{
    public class EntradaSaida
    {
        public Local Local { get; private set; }
        public TipoRegistro TipoRegistro { get; private set; }
        public int Quantidade { get; private set; }

    }
}
