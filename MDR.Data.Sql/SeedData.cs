using System.Data.Entity;

namespace MDR.Data.Sql
{
    public class SeedData : DropCreateDatabaseIfModelChanges<DamageReportContext>
    {
        private DamageReportContext Context { get; set; }

        public SeedData(DamageReportContext context)
        {
            Context = context;
        }

        private void Seed()
        {

        }
    }
}
