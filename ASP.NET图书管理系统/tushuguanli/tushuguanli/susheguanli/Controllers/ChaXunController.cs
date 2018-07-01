using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace susheguanli.Controllers
{
    public class ChaXunController : Controller
    {
        //Book quanJu;
        //
        // GET: /ChaXun/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View(dataBase.Select());
        }
        [HttpPost]
        public ActionResult getResponse(FormCollection f)
        {
            Int32 i = 0;
            try
            {
                i = Int32.Parse(f["name"]);
            }
            catch (FormatException e)
            {
                return PartialView("xianshi", dataBase.Select(f["name"]));
            }
            return PartialView("xianshi", dataBase.Select(i));
        }
    }
}
