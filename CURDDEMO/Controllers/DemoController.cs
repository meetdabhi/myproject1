using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CURDDEMO.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        DemoClass _demo = new DemoClass();
        public ActionResult Index()
        {
            var list = _demo.GetAll();
            return View(list);
        }
        public ActionResult Detail(int Id)
        {
            var data = _demo.GetById(Id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Detail(DemoTable fdata)
        {
            if(fdata.id>0)
            {
                _demo.Update(fdata);
            }
            else
            {
                _demo.Add(fdata);
            }
            return RedirectToAction("Index","Demo");
        }
        public ActionResult Delete(int Id)
        {
            _demo.Delete(Id);
            return RedirectToAction("Index", "Demo");
        }
        
    }
}