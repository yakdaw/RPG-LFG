using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodingKobold.LFG.Web.MVC.Models;
using Microsoft.Extensions.Configuration;

namespace CodingKobold.LFG.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        // Probably better put it in some kind of provider
        private readonly string _apiAddress;

        public HomeController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            _apiAddress = _configuration.GetValue<string>("ApiAddress");
        }

        public async Task<IActionResult> Index()
        {
            var uri = _apiAddress + "values/";
            try
            {
                var response = await _httpClient.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                return View(model: responseBody);
            }
            catch (HttpRequestException)
            {
                throw;
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}