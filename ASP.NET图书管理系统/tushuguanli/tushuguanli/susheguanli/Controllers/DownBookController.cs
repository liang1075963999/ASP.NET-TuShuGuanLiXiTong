using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class DownBookController : Controller
    {
        //
        // GET: /DownBook/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            int hao = Int32.Parse(f["name"]);
            System.Diagnostics.Debug.Write("我收到了：" + hao);
            dataBase.Delete(hao);
            return View(hao);
        }
    }
}
