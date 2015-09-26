using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace MDR.Data.Sql
{
    public class CustomConnectionFactory : IDbConnectionFactory
    {
        public DbConnection CreateConnection(string nameOrConnectionString)
        {
            var name = nameOrConnectionString.Split('.').Last().Replace("Context", string.Empty);

            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @".\SQLEXPRESS",
                AttachDBFilename = @"|DataDirectory|\DamageReportDb.mdf",
                InitialCatalog = name,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                UserInstance = false
            };
            return new SqlConnection(builder.ToString());
        }
    }
}
