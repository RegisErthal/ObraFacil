using Microsoft.EntityFrameworkCore;
using ObraFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraFacil.Infra.Contexts
{
    public class ObraFacilContext : DbContext   
    {
        private readonly string _connectionstring;

        public ObraFacilContext()
        {
        }
        public ObraFacilContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionstring ?? "Server=localhost;Port=3306;Database=dbobrafacil;Uid=root;Pwd=etapas;");
        }

        public DbSet<AlvenariaModel> Alvenaria { get; set; }
        public DbSet<CoberturaModel> Cobertura { get; set; }
        public DbSet<EletricaModel> Eletrica { get; set; }
        public DbSet<HidraulicaModel> Hidraulica { get; set; }
        public DbSet<FundacaoModel> Fundacao { get; set; }
    }
}
