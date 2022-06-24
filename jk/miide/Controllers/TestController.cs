using DALco;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miide.Controllers
{
        public class TestController : Controller
        {
                public readonly data_collection db;
          

                public TestController(data_collection info )
                {
                        this.db = info;
                }
                public IActionResult Index()
                {
                        ViewBag.Disease = new SelectList(db.diseases_table.ToList(), "id", "name_OF_disease");
                        ViewBag.Drugs = new SelectList(db.drug_table.ToList(), "id", "Scientific_name");
                        return View();
                }

                [HttpPost]
                public JsonResult SaveDrugToDis(int disId,List<int> drugsIds)
                {
                        try
                        {
                                foreach (var item in drugsIds)
                                {
                                        disease_drug o = new disease_drug()
                                        {
                                                diseaseId = disId,
                                                drugId = item
                                        };

                                        db.disease_drug_table.Add(o);
                                        db.SaveChanges();
                                        return Json(true);
                                }
                        }
                        catch 
                        {
                        }
                        return Json(false);
                }





        }

}
