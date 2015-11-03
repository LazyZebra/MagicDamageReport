using MDR.Data.Sql.Repositories;
using MDR.Domain.Model;
using MDR.Web.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MDR.Web.UI.Controllers
{
    public class DamageReportController : Controller
    {
        //IRepository<DamageReport> _repository;

        //public DamageReportController(DamageReportRepository repository)
        //{
        //    _repository = repository;
        //}

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

        [HttpPost]
        public JsonResult SaveReport(CreateDamageReportItemViewModel model)
        {
            if (ModelState.IsValid)
            {

                return Json("Success");
            }

            return Json("Error");
        }
    }
}
