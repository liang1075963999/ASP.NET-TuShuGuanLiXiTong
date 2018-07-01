using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class JieBookController : Controller
    {
        //
        // GET: /JieBook/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            JieShu b = new JieShu();
            b.shuhao = Int32.Parse(f["shuhao"]);
            b.shuming = f["shuming"];
            b.jieshurenxuehao = Int32.Parse(f["jieshurenxuehao"]);
            b.jieshurenname = f["jieshurenxingming"];
            b.jieshudate = f["jieshuriqi"];
            dataBase.Add(b);
            System.Diagnostics.Debug.Write(b.shuhao + "," + b.shuming);
            return View(b);
        }
    }
}
