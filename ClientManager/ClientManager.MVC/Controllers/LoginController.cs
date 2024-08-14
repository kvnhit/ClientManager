using ClientManager.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ClientManager.MVC.Controllers
{
    public class LoginController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7043/api");
        private readonly HttpClient _httpClient;

        public LoginController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Indexx()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cookieValue = ReadCookie();
            if (cookieValue != null)
            {
                var credentials = cookieValue.Split(':');
                var usuario = credentials[0];
                var senha = credentials[1];

                return RedirectToAction("Index", "ClientManager");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(_httpClient.BaseAddress + "/Login", content);

                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Login efetuado com sucesso";
                    var token = await response.Content.ReadAsStringAsync();
                    MakeCookie(model.Username, model.Password);
                    return RedirectToAction("Index", "ClientManager");
                }
                else
                {
                    TempData["errorMessage"] = "Credenciais inválidas";
                    ModelState.AddModelError(string.Empty, "Tentativa de login falhou.");
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        private void MakeCookie(string username, string password)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(2),
                HttpOnly = true, 
                Secure = true, 
                SameSite = SameSiteMode.Strict 
            };

            HttpContext.Response.Cookies.Append("ClientCookie", $"{username}:{password}", cookieOptions);
        }

        private string ReadCookie()
        {
            try
            {
                return HttpContext.Request.Cookies["ClientCookie"];
            }
            catch
            {
                return null;
            }
        }
    }
}
