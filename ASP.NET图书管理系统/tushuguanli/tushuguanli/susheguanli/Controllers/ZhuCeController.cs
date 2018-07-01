using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class ZhuCeController : Controller
    {
        //
        // GET: /ZhuCe/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            User b = new User();
            b.userbianhao = Int32.Parse(f["zhanghao"]);
            b.password = f["mima"];
            dataBase.Add(b);
            System.Diagnostics.Debug.Write(b.userbianhao + "," + b.password);
            return View(b);
        }
    }
}
