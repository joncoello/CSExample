using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using CS.Client.Web.Models;

namespace CS.Client.Web.Controllers
{
    public class ClientController : Controller
    {
        //TODO: goes in appsettings
        private const string BaseAddress = "http://localhost:60213/";

        public async Task<ActionResult> Clients()
        {
            var clients = new List<ClientViewModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response =  await client.GetAsync("api/client/");
                if (response.IsSuccessStatusCode)
                {
                    clients = await response.Content.ReadAsAsync<List<ClientViewModel>>();
                }
            }
            return View(clients);
        }

        public async Task<ActionResult> Client(int id)
        {
            ClientViewModel client = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BaseAddress);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync($"api/client/{id}");

                if (response.IsSuccessStatusCode)
                {
                    client = await response.Content.ReadAsAsync<ClientViewModel>();
                }
            }
            return View(client);
        }

        public ActionResult Tenant(string id)
        {
            return Content($"The tenant id is {id}");
        }
    }
}