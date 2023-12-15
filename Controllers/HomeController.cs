using BLL;
using Microsoft.AspNetCore.Mvc;
using SmsPanel.Models;
using SmsPanel.Models.Dto;
using SmsPanel.Services;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;

namespace SmsPanel.Controllers
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
        [Route("i/{CodeFactor}")]
        public IActionResult Factor(string CodeFactor)
        {
            if (CodeFactor.Length == 0)
            {
                return NotFound();
            }

            StoreService service = new StoreService();
            StoreDto data = service.GetData(CodeFactor);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
