using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReCaptcha.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReCaptcha.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm]ContactModel model)
        {
            if (!ModelState.IsValid) return View(model);

            //var captchaResponse = Request.Form["g-recaptcha-response"];
            //var isValid = await IsCaptchaValid(captchaResponse);
            var result = await VerifyCaptcha(model.ReCaptcha);

            if (!result.Success)
            {
                ModelState.AddModelError("", "Please click on the \"I'm not a robot\" checkbox");
                return View(model);
            }
            
            return View("Thanks");
        }

        /// <summary>
        /// verify the captcha's response with Google
        /// </summary>
        private async Task<CaptchaVerification> VerifyCaptcha(string captchaResponse)
        {
            string userIP = string.Empty;
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (ipAddress != null) userIP = ipAddress.MapToIPv4().ToString();            
            
            var payload = string.Format("&secret={0}&remoteip={1}&response={2}", "6LfClBYUAAAAAOa4-NNjj_CpcQObnNakb83rBlN6", userIP, captchaResponse);
            
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.google.com");
            var request = new HttpRequestMessage(HttpMethod.Post, "/recaptcha/api/siteverify")
            {
                Content = new StringContent(payload, Encoding.UTF8, "application/x-www-form-urlencoded")
            };

            var response = await client.SendAsync(request); 
            return JsonConvert.DeserializeObject<CaptchaVerification>(response.Content.ReadAsStringAsync().Result);
        }

        public IActionResult Ajax()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ajax([FromForm]ContactModel model)
        {
            if (!ModelState.IsValid) return View(model);
            //continue processing
            //save the data
            return View("Thanks");
        }

        
        [HttpPost("api/captcha/verify")]
        public async Task<IActionResult> Verify(string captchaResponse)
        {

            var result = await VerifyCaptcha(captchaResponse);
            return new JsonResult(result);
        }
    }
}
