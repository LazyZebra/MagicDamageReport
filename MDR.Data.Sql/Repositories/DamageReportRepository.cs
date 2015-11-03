using MDR.Domain.Model;

namespace MDR.Data.Sql.Repositories
{
    public class DamageReportRepository : IRepository<DamageReport>
    {
        private DamageReportContext _context;

        public DamageReportRepository(DamageReportContext context)
        {
            _context = context;
        }

        public void Add(DamageReport entity)
        {
            _context.DamageReports.Add(entity);
        }
    }
}
