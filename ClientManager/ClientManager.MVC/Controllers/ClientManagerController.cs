using ClientManager.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ClientManager.MVC.Controllers
{
    public class ClientManagerController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7043/api");
        private readonly HttpClient _httpClient;
        
        public ClientManagerController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ClientViewModel> clientsList = new List<ClientViewModel>();
            HttpResponseMessage httpResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "/Client/Get?query=1");

            if (httpResponse.IsSuccessStatusCode)
            {
                string data = await httpResponse.Content.ReadAsStringAsync();
                clientsList = JsonConvert.DeserializeObject<List<ClientViewModel>>(data);
            }

            return View(clientsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientViewModel model)
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponse = await _httpClient.PostAsync(_httpClient.BaseAddress + "/Client/Post", content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Cliente cadastrado";
                    return RedirectToAction("Index");
                }
            } 
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                ClientViewModel clientViewModel = new ClientViewModel();
                HttpResponseMessage httpResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "/Client/GetById/" + id);

                if (httpResponse.IsSuccessStatusCode)
                {
                    string data = await httpResponse.Content.ReadAsStringAsync();
                    clientViewModel = JsonConvert.DeserializeObject<ClientViewModel>(data);
                }
                return View(clientViewModel);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ClientViewModel model)
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponse = await _httpClient.PutAsync(_httpClient.BaseAddress + "/Client/Put/" + model.Id , content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Cliente atualizado";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                ClientViewModel clientViewModel = new ClientViewModel();
                HttpResponseMessage httpResponse = await _httpClient.GetAsync(_httpClient.BaseAddress + "/Client/GetById/" + id);

                if (httpResponse.IsSuccessStatusCode)
                {
                    string data = await httpResponse.Content.ReadAsStringAsync();
                    clientViewModel = JsonConvert.DeserializeObject<ClientViewModel>(data);
                }
                return View(clientViewModel);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                HttpResponseMessage httpResponse = await _httpClient.DeleteAsync(_httpClient.BaseAddress + "/Client/Delete/" + id);

                if (httpResponse.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Cliente excluído";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }
    }
}
