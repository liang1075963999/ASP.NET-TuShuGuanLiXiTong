using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class HuanBookController : Controller
    {
        //
        // GET: /HuanBook/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            HuanShu b = new HuanShu();
            b.shuhao = Int16.Parse(f["shuhao"]);
            b.shuming = f["shuming"];
            b.huanshurenxuehao = Int32.Parse(f["huanshurenxuehao"]);
            b.huanshurenname = f["huanshurenxingming"];
            b.huanshurendate = f["huanshuriqi"];
            dataBase.Add(b);
            dataBase.Delete(b);
            System.Diagnostics.Debug.Write(b.shuhao + "," + b.shuming);
            return View(b);
        }
    }
}
