using System;
using System.Collections.Generic;

namespace MDR.Domain.Model
{
    public class DamageReport: BaseModel
    {
        public DateTime CreatedOn { get; set; }
        public DamageEntityType DamageEntityType { get; set; }
        public ReportingCompany ReportingCompany { get; set; }

        public virtual ICollection<DamageReportItem> DamageReportItems { get; set; } 
    }
}
