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
            return View();
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


        public class Building
        {
        public decimal Id { get; set; }

        }

        public class Battery
        {
        public decimal Id { get; set; }

        }

        public class Column
        {
        public decimal Id { get; set; }

        }

        public class Elevator
        {
        public decimal Id { get; set; }

        }

        public class Customer
        {
        public decimal Id { get; set; }

        }

        class Program
        {
            static HttpClient client = new HttpClient();

            static void ShowProduct(Battery battery)
            {
                Console.WriteLine($"Name: {battery.Id});
            }


            static async Task<Uri> CreateProductAsync(Battery battery)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    "api/battery", battery);
                response.EnsureSuccessStatusCode();

                // return URI of the created resource.
                return response.Headers.Location;
            }

            static async Task<Battery> GetProductAsync(string path)
            {
                Battery battery = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    battery = await response.Content.ReadAsAsync<Battery>();
                }
                return battery;
            }

            static async Task<Battery> UpdateProductAsync(Battery battery)
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                    $"api/battery/{battery.Id}", battery);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                battery = await response.Content.ReadAsAsync<Battery>();
                return battery;
            }

            static async Task<HttpStatusCode> DeleteProductAsync(string id)
            {
                HttpResponseMessage response = await client.DeleteAsync(
                    $"api/battery/{id}");
                return response.StatusCode;
            }

            static void Main()
            {
                RunAsync().GetAwaiter().GetResult();
            }

            static async Task RunAsync()
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri("https://rocket-elevator-restapi.azurewebsites.net/api/battery/all");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    // Create a new product
                    Battery battery = new Battery
                    {
                        Id = 14
                    };

                    var url = await CreateProductAsync(battery);
                    Console.WriteLine($"Created at {url}");

                    // Get the product
                    battery = await GetProductAsync(url.PathAndQuery);
                    ShowProduct(battery);

                    // Update the product
                    Console.WriteLine("Updating price...");
                    battery.Id = 80;
                    await UpdateProductAsync(battery);

                    // Get the updated product
                    battery = await GetProductAsync(url.PathAndQuery);
                    ShowProduct(battery);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();
            }
        }


    }
}
