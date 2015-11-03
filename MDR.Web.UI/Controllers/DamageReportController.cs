using MDR.Web.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MDR.Web.UI.Controllers
{
    public class DamageReportController : Controller
    {
        public ActionResult Index()
        {
            var damageReport = new CreateDamageReportViewModel();

            damageReport.DamageReportItems = new List<CreateDamageReportItemViewModel>()
                {
                    new CreateDamageReportItemViewModel()
                    {
                    DamageArea = "Area 1",
                    DamageEstimatedCost = 100.00,   
                    DamageSeverity = "High"
                }
            };

            return View(damageReport);
        }

        public JsonResult Save()
        {
            return Json("");
        }
    }
}
