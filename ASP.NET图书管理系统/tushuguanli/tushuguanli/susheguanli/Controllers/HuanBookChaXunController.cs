using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class HuanBookChaXunController : Controller
    {
        //
        // GET: /HuanBookChaXun/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View(dataBase.SelectHuan());
        }
        [HttpPost]
        public ActionResult getResponse(FormCollection f)
        {
            System.Diagnostics.Debug.Write(Int32.Parse(f["name"]));
            return PartialView("xianshihuan", dataBase.SelectHuan(Int32.Parse(f["name"])));
        }
    }
}
