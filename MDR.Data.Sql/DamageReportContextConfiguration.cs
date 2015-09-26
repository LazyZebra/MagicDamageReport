using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MDR.Data.Sql
{
    public class DamageReportContextConfiguration : DbConfiguration
    {
        public DamageReportContextConfiguration()
        {
            SetDefaultConnectionFactory(new CustomConnectionFactory());
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
        }
    }
}
