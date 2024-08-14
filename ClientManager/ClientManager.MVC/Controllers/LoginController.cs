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
    }
}
