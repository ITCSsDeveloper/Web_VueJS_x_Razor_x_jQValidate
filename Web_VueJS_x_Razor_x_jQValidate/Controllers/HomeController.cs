using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web_VueJS_x_Razor_x_jQValidate.Models;

namespace Web_VueJS_x_Razor_x_jQValidate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var homeModel = new HomeModel();
            homeModel.CustomerInfo = new List<CustomerInfo>
            {
                new CustomerInfo{
                    BirthDate = DateTime.Now
                },
            };

            return View(homeModel);
        }
    }
}