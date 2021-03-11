using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReCap.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using var client = new WebClient();

            var result =  client.DownloadString("https://localhost:44392/api/cars/getall");
            
            return View();
        }
    }
}
