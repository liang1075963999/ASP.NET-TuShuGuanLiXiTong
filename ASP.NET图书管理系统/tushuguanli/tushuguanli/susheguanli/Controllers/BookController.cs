using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Models
{
    public class BookController : Controller
    {
        public DataBase dataBase = new DataBase();
        //
        // GET: /Book/

        public ActionResult Index()
        {
            System.Diagnostics.Debug.Write("b.shuhao ");
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            Book b = new Book();
            b.shuhao = Int32.Parse(f["shuhao"]);
            b.shuming = f["shuming"];
            b.jiaqian = Double.Parse(f["jiaqian"]);
            b.zuozhe = f["zuozhe"];
            b.zaiguanceshu = f["zaiguanceshu"];
            b.neirongjianjie = f["neirongjianjie"];
            dataBase.Add(b);
            System.Diagnostics.Debug.Write(b.shuhao + "," + b.shuming);
            return View(b);
        }
    }
}
