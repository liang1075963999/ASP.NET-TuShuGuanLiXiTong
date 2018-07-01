using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class DengLuController : Controller
    {
        //
        // GET: /DengLu/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection f)
        {
            System.Diagnostics.Debug.Write("账号和密码分别是:" + Int32.Parse(f["account"]) + "@" + f["password"]);
            DataBase.userHao = Int32.Parse(f["account"]);
            int response = dataBase.userPanDuan(Int32.Parse(f["account"]), f["password"]);
            System.Diagnostics.Debug.Write("response是" + response);
            if (response == 0)
            {
                System.Diagnostics.Debug.Write("我要跳转了");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            //return RedirectToAction("Index", "Home");
        }
    }
}
