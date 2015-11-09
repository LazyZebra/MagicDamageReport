using System;
using System.Linq;
using System.Linq.Expressions;

using MDR.Domain.Model;

namespace MDR.DataAccess.Repositories
{
    public class DamageReportRepository : IRepository<DamageReport> 
    {
        public void Add(DamageReport entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(DamageReport entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DamageReport> Find(Expression<Func<DamageReport, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
