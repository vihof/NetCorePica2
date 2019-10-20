using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {

        // GET: /HomeController/
        public string Index()
        {   
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}