using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login( string userName, string password, string selectColor)
        {
            ViewBag.userName = userName;
            ViewBag.password = password;
            ViewBag.selectColor = selectColor;


            if (Session["userName"] == null)
            {
                Session.Add("userName", userName);
            }

            if (Session["password"] == null)
            {
                Session.Add("password", password);
            }

            if (Session["selectColor"] == null)
            {
                Session.Add("selectColor", selectColor);
            }



            if (Session["Counter"] == null)
            {
                Session.Add("Counter",0);
            }
            int visits = (int)Session["Counter"];
            visits++;
            Session["Counter"] = visits;
            return View();
        }
    }
}