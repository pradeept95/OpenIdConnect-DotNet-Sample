using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NINDS_IRMB_APP.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace NINDS_IRMB_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            TempData["ReturnUrl"] = "/home/privacy";
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        
        [Authorize]
        public IActionResult Profile()
        {
            Dictionary<string, string> userDictionary = new Dictionary<string, string>();

            foreach (var claim in _httpContextAccessor.HttpContext.User.Claims)
            {
                userDictionary.Add(claim.Type, claim.Value);
            } 

            string user = JsonConvert.SerializeObject(userDictionary, Formatting.Indented); 
            UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(user); ;
            return View(profile);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    } 
}
