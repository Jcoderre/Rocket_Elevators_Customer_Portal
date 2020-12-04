using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rocket_Elevators_Customer_Portal.Models;




namespace Rocket_Elevators_Customer_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult view_data()
        {
            IEnumerable<Battery> batteries = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64189/api/");
                //HTTP GET
                var responseTask = client.GetAsync("student");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Battery>>();
                    readTask.Wait();

                    batteries = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    batteries = Enumerable.Empty<Battery>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(batteries);
        }

        public IActionResult manage_data()
        {
            return View();
        }    

        public IActionResult intervention_form()
        {
            return View();
        } 

        public IActionResult buildings()
        {
            return View();
        }    

        public IActionResult batteries()
        {
            return View();
        }    

        public IActionResult columns()
        {
            return View();
        }    

        public IActionResult elevators()
        {
            return View();
        } 

        public IActionResult interventions_view()
        {
            return View();
        }         

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }
}
