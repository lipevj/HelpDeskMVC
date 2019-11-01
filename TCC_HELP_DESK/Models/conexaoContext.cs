using System.Data.Entity;

namespace TCC_HELP_DESK.Models
{
    public class conexaoContext : DbContext
    {
        public conexaoContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TCC_HELP_DESK.Models.Prioridades> Prioridades { get; set; }

        public System.Data.Entity.DbSet<TCC_HELP_DESK.Models.Categorias> Categorias { get; set; }

        public System.Data.Entity.DbSet<TCC_HELP_DESK.Models.Chamados> Chamados { get; set; }

        public System.Data.Entity.DbSet<TCC_HELP_DESK.Models.Status> Status { get; set; }

   
    }
}