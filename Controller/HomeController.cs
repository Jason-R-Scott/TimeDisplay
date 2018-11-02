using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioI
{

    public class HomeController : Controller
    {

        [HttpGet ("")]

        public ViewResult Index ()
        {
            return View();
        }

    }

}