using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondPractise2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string result = "Вы не авторизованы";
            if (User.Identity.IsAuthenticated)
            {
                result = "name: " + User.Identity.Name;
            }
            return result;
        }
    }

   
}