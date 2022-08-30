using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NINDS_IRMB_APP.Auth;
using NINDS_IRMB_APP.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Diagnostics;

namespace NINDS_IRMB_APP.Controllers
{
    public class AccountController : Controller
    {
        private readonly IOptions<OidcOptions> options; 

        public AccountController(IOptions<OidcOptions> options)
        {
            this.options = options;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Login(string returnUrl = null)
        {  
            return RedirectToRoute(returnUrl ?? "/home/index");
        } 
        
        [HttpGet]
        public async Task<IActionResult> Logout()
        { 
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);  
           // return Redirect($"{options.Value.Authority}/session/end"); 

            return RedirectToAction("Index", "Home");
        }  

        [HttpGet]
        [AllowAnonymous] 
        public IActionResult AccessDenied()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    } 
}
