using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class JieBookChaXunController : Controller
    {
        //
        // GET: /JieHuanBookChaXun/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View(dataBase.SelectJie());
        }
        [HttpPost]
        public ActionResult getResponse(FormCollection f)
        {
            System.Diagnostics.Debug.Write(Int32.Parse(f["name"]));
            return PartialView("xianshijie", dataBase.SelectJie(Int32.Parse(f["name"])));
        }
    }
}
