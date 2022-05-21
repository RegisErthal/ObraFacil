using Microsoft.EntityFrameworkCore;
using ObraFacil.Models;
using ObraFacil.Pages.Etapas;

namespace ObraFacil.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet <AlvenariaModel> Alvenaria { get; set; }
        public DbSet<CoberturaModel> Cobertura { get; set; }
        public DbSet<EletricaModel> Eletrica { get; set; }
        public DbSet<HidraulicaModel> Hidraulica { get; set; }
        public DbSet<FundacaoModel> Fundacao { get; set; }



    }
}
