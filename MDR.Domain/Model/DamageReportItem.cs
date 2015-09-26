using System;

namespace MDR.Domain.Model
{
    public class DamageReportItem : BaseModel
    {
        public DamageArea DamageArea { get; set; }
        public DamageSeverity DamageSeverity { get; set; }
        public DamageEstimatedCost DamageEstimatedCost { get; set; }
    }
}
