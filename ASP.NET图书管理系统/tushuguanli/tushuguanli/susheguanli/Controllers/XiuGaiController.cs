using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class XiuGaiController : Controller
    {
        public DataBase dataBase = new DataBase();
        //
        // GET: /XiuGai/

        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            Book b = new Book();
            b.shuhao = Int16.Parse(f["shuhao"]);
            b.shuming = f["shuming"];
            b.jiaqian = Double.Parse(f["jiaqian"]);
            b.zuozhe = f["zuozhe"];
            b.zaiguanceshu = f["zaiguanceshu"];
            b.neirongjianjie = f["neirongjianjie"];
            dataBase.Update(b.shuhao, b.shuming, (double)b.jiaqian, b.zuozhe, b.zaiguanceshu, b.neirongjianjie);
            System.Diagnostics.Debug.Write(b.shuhao + "," + b.shuming);
            return View(b);
        }
    }
}
