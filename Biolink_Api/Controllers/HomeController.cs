using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biolink_Api.Connections;

namespace Biolink_Api.Controllers
{
    public class HomeController : Controller
    {
        ConnectionConfig ConnectionConfig = new ConnectionConfig();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ConnectionConfig.ConnectMySql();
            return View();
        }
    }
}
