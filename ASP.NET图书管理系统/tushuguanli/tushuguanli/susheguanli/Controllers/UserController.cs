using susheguanli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace susheguanli.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public DataBase dataBase = new DataBase();
        public ActionResult Index()
        {
            return View(dataBase.SelectUser());
        }

    }
}
