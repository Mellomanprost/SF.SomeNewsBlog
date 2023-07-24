using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SNBProject.ViewModels;
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
        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 400 || statusCode == 404)
                {
                    var viewName = statusCode.ToString();
                    Logger.Error($"Произошла ошибка - {statusCode}\n{viewName}");
                    return View(viewName);
                }
                else 
                    if (statusCode == 403)
                        return View("403");

                    return View("400");
            }
            return View("400");
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //generate error 400
        public IActionResult Error400()
        {
            try
            {
                throw new HttpRequestException("400");
            }
            catch
            {
                return View("400");
            }
        }

        //generate error 403
        public IActionResult Error403()
        {
            try
            {
                throw new HttpRequestException("403");
            }
            catch
            {
                return View("403");
            }
        }

        //generate error 404
        public IActionResult Error404()
        {
            try
            {
                throw new HttpRequestException("404");
            }
            catch
            {
                return View("404");
            }
        }
    }
}