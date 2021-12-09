using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GNV_Web.Models;
using MySql.Data.MySqlClient;

namespace GNV_Web.Data
{
    public class GNV_WebContext : DbContext
    {
        public GNV_WebContext (DbContextOptions<GNV_WebContext> options)  : base(options)
        {
        }

        //public DbSet<GNV_Web.Models.Local> Empresa { get; set; }
        public DbSet<GNV_Web.Models.Cidade> Cidade { get; set; }
        public DbSet<GNV_Web.Models.Bairro> Bairro { get; set; }
        public DbSet<GNV_Web.Models.Endereco> Endereco { get; set; }
        public DbSet<GNV_Web.Models.Empresa> Empresa { get; set; }
        public DbSet<GNV_Web.Models.Costureira> Costureira { get; set; }
        public DbSet<GNV_Web.Models.Remessa> Remessa { get; set; }
        public DbSet<GNV_Web.Models.UnidadeMedida> Unidade_Medida { get; set; }
        public DbSet<GNV_Web.Models.Tecido> Tecido { get; set; }
        public DbSet<GNV_Web.Models.CorEstampa> CorEstampa { get; set; }
        public DbSet<GNV_Web.Models.Pano> Pano { get; set; }
        public DbSet<GNV_Web.Models.ItemRemessa> Item_Remessa { get; set; }



    }
}
