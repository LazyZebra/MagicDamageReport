using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MDR.Web.UI.Models
{
    public class CreateDamageReportViewModel
    {
        public CreateDamageReportViewModel()
        {
            DamageReportItems = new List<CreateDamageReportItemViewModel>();
        }

        [Required]
        [Display(Name = "Report Name")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 40")]
        [DataType(DataType.Text, ErrorMessage = "Report Name can contain letters only")]
        public string ReportName { get; set; }

        [Required]
        [Display(Name = "Damage Type")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [DataType(DataType.Text, ErrorMessage = "Damage Entity Type can contain letters only")]
        public string DamageEntityType { get; set; }

        [Required]
        [Display(Name = "Created On")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [DataType(DataType.Text, ErrorMessage = "Company Name can contain letters only")]
        public string CompanyName { get; set; }

        public IEnumerable<CreateDamageReportItemViewModel> DamageReportItems { get; set; }
    }

    public class CreateDamageReportItemViewModel
    {
        [Required]
        [Display(Name = "Damage Area")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [DataType(DataType.Text)]
        public string DamageArea { get; set; }

        [Required]
        [Display(Name = "Severity")]
        [MinLength(2, ErrorMessage = "Minimum length is 2")]
        [MaxLength(20, ErrorMessage = "Maximum length is 20")]
        [DataType(DataType.Text)]
        public string DamageSeverity { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Estimated Cost")]
        public double DamageEstimatedCost { get; set; }
    }
}
