using credit_control_api.core.Entities;
using Microsoft.EntityFrameworkCore;

namespace credit_control_api.infraestructure.DataAccess.Contexts
{
    public partial class CreditControlContext : DbContext
    {
        public CreditControlContext(DbContextOptions<CreditControlContext> options)
        : base(options)
        {
        }

        public DbSet<Debt> Debt { get; set; }
        public DbSet<Debtor> Debtor { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
