using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SNBProject.ViewModels;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SNB.BLL.Services.IServices;
using NLog;

namespace SNBProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            await _homeService.GenerateData();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}