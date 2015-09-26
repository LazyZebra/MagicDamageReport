using System.Data.Entity;
using MDR.Domain.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MDR.Data.Sql
{
    public class DamageReportContext : DbContext
    {
        public DamageReportContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DamageReportContext>());
        }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<DamageReport> DamageReports { get; set; }
        public DbSet<DamageArea> DamageAreas { get; set; }
        public DbSet<DamageEntityType> DamageEntityTypes { get; set; }
        public DbSet<DamageSeverity> DamageSeverities { get; set; }
        public DbSet<ReportingCompany> ReportingCompanies { get; set; }

    }
}
